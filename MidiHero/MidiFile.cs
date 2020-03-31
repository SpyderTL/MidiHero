using System;
using System.Collections.Generic;
using System.IO;

namespace MidiHero
{
	internal static class MidiFile
	{
		internal static void Load(string fileName)
		{
			Song.Name = Path.GetFileNameWithoutExtension(fileName);

			using (var stream = System.IO.File.OpenRead(fileName))
			using (var reader = new System.IO.BinaryReader(stream))
			{
				ReadHeader(reader);

				for (var track = 0; track < Song.Tracks.Length; track++)
					ReadTrack(reader, track);
			}
		}

		private static void ReadHeader(System.IO.BinaryReader reader)
		{
			var signature = reader.ReadChars(4);
			var length = reader.ReadBigEndianUInt32();

			var format = reader.ReadBigEndianUInt16();
			var tracks = reader.ReadBigEndianUInt16();
			var ticks = reader.ReadBigEndianUInt16();

			Song.Tracks = new Song.Track[tracks];
			Song.TicksPerBeat = (int)ticks;
		}

		private static void ReadTrack(System.IO.BinaryReader reader, int track)
		{
			var signature = reader.ReadChars(4);
			var length = reader.ReadBigEndianUInt32();

			var start = reader.BaseStream.Position;

			var events = new List<Song.Event>();
			var lastStatus = (byte)0;

			while (true)
			{
				var delay = reader.ReadQuantity();
				var status = reader.ReadByte();

				if ((status & 0x80) == 0)
				{
					status = lastStatus;
					reader.BaseStream.Seek(-1, System.IO.SeekOrigin.Current);
				}

				switch (status)
				{
					case 0xFF:
						ReadMetaEvent(reader, track, (int)delay, events);
						break;

					case 0xF0:
						ReadSystemExclusiveEvent(reader, track);
						break;

					default:
						var e = ReadTrackEvent(reader, track, status);
						e.Delay = (int)delay;

						events.Add(e);
						break;
				}

				lastStatus = status;

				if (reader.BaseStream.Position == start + length)
					break;
			}

			Song.Tracks[track].Events = events.ToArray();
		}

		private static Song.Event ReadTrackEvent(BinaryReader reader, int track, byte status)
		{
			var messageType = status >> 4;
			var channel = (byte)(status & 0xf);

			switch (messageType)
			{
				case 0x8:
					return new Song.Event { Type = Song.EventType.NoteOff, Channel = channel, Value = reader.ReadByte(), Value2 = reader.ReadByte() };

				case 0x9:
					return new Song.Event { Type = Song.EventType.NoteOn, Channel = channel, Value = reader.ReadByte(), Value2 = reader.ReadByte() };

				case 0xa:
					return new Song.Event { Type = Song.EventType.KeyPressure, Channel = channel, Value = reader.ReadByte(), Value2 = reader.ReadByte() };

				case 0xb:
					var value1 = reader.ReadByte();
					var value2 = reader.ReadByte();

					switch (value1)
					{
						case 0x78:
							//return "All Sound Off";
							return new Song.Event { Type = Song.EventType.Delay, Channel = channel };

						case 0x79:
							//return "Reset All Controllers";
							return new Song.Event { Type = Song.EventType.Delay, Channel = channel };

						case 0x7a:
							//return "Local Control";
							return new Song.Event { Type = Song.EventType.Delay, Channel = channel };

						case 0x7b:
							//return "All Notes Off";
							return new Song.Event { Type = Song.EventType.Delay, Channel = channel };

						case 0x7c:
							//return "Omni Mode Off";
							return new Song.Event { Type = Song.EventType.Delay, Channel = channel };

						case 0x7d:
							//return "Omni Mode On";
							return new Song.Event { Type = Song.EventType.Delay, Channel = channel };

						case 0x7e:
							//return "Mono Mode On";
							return new Song.Event { Type = Song.EventType.Delay, Channel = channel };

						case 0x7f:
							//return "Poly Mode On";
							return new Song.Event { Type = Song.EventType.Delay, Channel = channel };

						default:
							return new Song.Event { Type = Song.EventType.ControlChange, Channel = channel, Value = value1, Value2 = value2 };
					}

				case 0xc:
					return new Song.Event { Type = Song.EventType.ProgramChange, Channel = channel, Value = reader.ReadByte() };
					//return new ProgramChange { Delay = delay, Channel = channel, Patch = reader.ReadByte(), Unknown = 0 };

				case 0xd:
					return new Song.Event { Type = Song.EventType.ChannelPressure, Channel = channel, Value = reader.ReadByte() };
				//return new ChannelPressure { Delay = delay, Channel = channel, Velocity = reader.ReadByte(), Unknown = 0 };

				case 0xe:
					return new Song.Event { Type = Song.EventType.PitchBend, Channel = channel, Value = reader.ReadByte() | (reader.ReadByte() << 8) };
				//return new PitchBendChange { Delay = delay, Channel = channel, Value = BitConverter.ToUInt16(reader.ReadBytes(2).Reverse().ToArray(), 0) };

				default:
					throw new NotSupportedException();
					//value1 = reader.ReadByte();
					//value2 = reader.ReadByte();
					//return "Unknown";
			}

			throw new NotSupportedException();
		}

		private static void ReadMetaEvent(BinaryReader reader, int track, int delay, List<Song.Event> events)
		{
			var type = reader.ReadByte();
			var length = (int)ReadQuantity(reader);

			switch (type)
			{
				case 0x00:
					reader.ReadBytes(length);
					//return "Sequence Number";

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });
					break;

				case 0x01:
					var text = new string(reader.ReadChars(length));
					//reader.ReadBytes(length);
					//return "Text Event: " + text;

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });
					break;

				case 0x02:
					var copyright = new string(reader.ReadChars(length));
					//reader.ReadBytes(length);
					//return "Copyright Notice: " + copyright;

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });
					break;

				case 0x03:
					var name = new string(reader.ReadChars(length));
					//return "Sequence/Track Name: " + name;

					Song.Tracks[track].Name = name;

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });
					break;

				case 0x04:
					var instrument = new string(reader.ReadChars(length));
					//reader.ReadBytes(length);

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });

					//return "Instrument Name: " + instrument;
					break;

				case 0x05:
					var lyric = new string(reader.ReadChars(length));

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });

					//return "Lyric: " + lyric;
					break;

				case 0x06:
					reader.ReadBytes(length);

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });

					//return "Marker";
					break;

				case 0x07:
					reader.ReadBytes(length);

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });

					//return "Cue Point";
					break;

				case 0x20:
					reader.ReadBytes(length);

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });

					//return "MIDI Channel Prefix";
					break;

				case 0x21:
					var data = reader.ReadBytes(length);
					var port = data[0];

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });

					//return "MIDI Port Prefix:" + port;
					break;

				case 0x2F:
					reader.ReadBytes(length);

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });

					//return "End Of Track";
					break;

				case 0x51:
					data = reader.ReadBytes(length);
					var tempo = (data[0] << 16) | (data[1] << 8) | data[2];

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.SetTempo, Value = tempo });

					//return "Set Tempo: " + tempo;
					break;

				case 0x54:
					data = reader.ReadBytes(length);

					var hours = data[0] & 0x1f;
					var minutes = data[1];
					var seconds = data[2];
					var frames = data[3];
					var subframes = data[4];

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });

					//events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay, Value = seconds * 1000 });
					//return "SMTPE Offset";
					break;

				case 0x58:
					data = reader.ReadBytes(length);

					var numerator = data[0];
					var denominator = data[1];
					var midiClocksPerTick = data[2];
					var thirtySecondNotes = data[3];

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });

					//return "Time Signature: " + numerator + "/" + denominator + " (" + midiClocksPerTick + ") [" + thirtySecondNotes + "]";
					break;

				case 0x59:
					data = reader.ReadBytes(length);

					var key = data[0];
					var minor = data[1];

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });

					//return "Key Signature";
					break;

				case 0x7f:
					data = reader.ReadBytes(length);

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });

					//return "Sequencer Event";
					break;

				default:
					data = reader.ReadBytes(length);

					events.Add(new Song.Event { Delay = delay, Type = Song.EventType.Delay });

					break;
			}
		}

		private static void ReadSystemExclusiveEvent(BinaryReader reader, int track)
		{
			var length = (int)ReadQuantity(reader);

			reader.ReadBytes(length);
		}

		private static uint ReadBigEndianUInt32(this System.IO.BinaryReader reader)
		{
			var data = reader.ReadBytes(4);

			return (uint)data[0] << 24 | (uint)data[1] << 16 | (uint)data[2] << 8 | data[3];
		}

		private static uint ReadBigEndianUInt16(this System.IO.BinaryReader reader)
		{
			var data = reader.ReadBytes(2);

			return (uint)data[0] << 8 | data[1];
		}

		private static uint ReadQuantity(this System.IO.BinaryReader reader)
		{
			var quantity = 0U;

			while (true)
			{
				var data = reader.ReadByte();

				var value = (uint)data & 0x7f;

				quantity <<= 7;
				quantity |= value;

				if ((data & 0x80) == 0)
					break;
			}

			return quantity;
		}
	}
}