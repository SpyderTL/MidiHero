using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiHero
{
	internal static class Song
	{
		internal static string Name;
		internal static Track[] Tracks;
		internal static int TicksPerBeat;

		internal struct Track
		{
			internal string Name;
			internal Event[] Events;
		}

		internal struct Event
		{
			internal int Delay;
			internal int Channel;
			internal EventType Type;
			internal int Value;
			internal int Value2;
		}

		internal enum EventType
		{
			NoteOn,
			NoteOff,
			ProgramChange,
			ControlChange,
			PitchBend,
			SetTempo,
			Delay,
			ChannelPressure
		}
	}
}
