using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiHero
{
	internal static class SongPlayer
	{
		internal static Song.Track[] Tracks;
		internal static double TicksPerBeat;
		internal static double[] Timers;
		internal static int[] Next;
		internal static bool Paused;
		internal static bool Stopped;
		internal static bool[] Playing;
		internal static double MillisecondsPerBeat;

		internal static System.Threading.Thread Thread;

		internal static void Play()
		{
			if (Thread == null)
			{
				Thread = new System.Threading.Thread(Start);
				Thread.Start();
			}
		}

		internal static void Pause()
		{
			Paused = true;
		}

		internal static void Resume()
		{
			Paused = false;
		}

		internal static void Stop()
		{
			Stopped = true;
		}

		private static void Start()
		{
			Tracks = Song.Tracks;
			TicksPerBeat = Song.TicksPerBeat;

			Timers = new double[Tracks.Length];
			Next = new int[Tracks.Length];
			Playing = new bool[Tracks.Length];

			for (var track = 0; track < Tracks.Length; track++)
			{
				if (Tracks[track].Events.Length != 0)
				{
					Playing[track] = true;
					Timers[track] = Tracks[track].Events[0].Delay;
				}
			}

			MillisecondsPerBeat = 500000.0;

			Midi.Enable();

			// All Sound Off
			for(var channel = 0; channel < 16; channel++)
				Midi.ControlChange(channel, 120, 0);

			var last = DateTime.Now;
			Stopped = false;

			while (!Stopped)
			{
				var now = DateTime.Now;
				var elapsed = now - last;
				last = now;

				var microseconds = elapsed.Ticks * 0.1;
				var beats = microseconds / MillisecondsPerBeat;
				var ticks = beats * TicksPerBeat;

				var playing = false;

				for (int track = 0; track < Tracks.Length; track++)
				{
					if (Playing[track])
					{
						Timers[track] -= ticks;

						playing = true;
					}

					while (Playing[track] && Timers[track] <= 0)
					{
						var e = Tracks[track].Events[Next[track]];

						switch (e.Type)
						{
							case Song.EventType.NoteOn:
								Midi.NoteOn(e.Channel, e.Value, e.Value2);
								break;

							case Song.EventType.NoteOff:
								Midi.NoteOff(e.Channel, e.Value, e.Value2);
								break;

							case Song.EventType.KeyPressure:
								Midi.KeyPressure(e.Channel, e.Value, e.Value2);
								break;

							case Song.EventType.ProgramChange:
								Midi.ProgramChange(e.Channel, e.Value);
								break;

							case Song.EventType.ControlChange:
								Midi.ControlChange(e.Channel, e.Value, e.Value2);
								break;

							case Song.EventType.PitchBend:
								Midi.PitchBend(e.Channel, e.Value);
								break;

							case Song.EventType.ChannelPressure:
								Midi.ChannelPressure(e.Channel, e.Value);
								break;

							case Song.EventType.SetTempo:
								MillisecondsPerBeat = e.Value;
								break;
						}

						Next[track]++;

						if (Next[track] == Tracks[track].Events.Length)
							Playing[track] = false;
						else
							Timers[track] += Tracks[track].Events[Next[track]].Delay;
					}
				}

				if (!playing)
					Stopped = true;
				else
					System.Threading.Thread.Sleep(10);
			}

			// All Sound Off
			for (var channel = 0; channel < 16; channel++)
				Midi.ControlChange(channel, 120, 0);

			Midi.Disable();

			Thread = null;
		}
	}
}
