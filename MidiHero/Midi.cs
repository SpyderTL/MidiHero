using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MidiHero
{
	public static class Midi
	{
		[DllImport("winmm.dll")]
		static extern uint midiOutOpen(out IntPtr lphMidiOut, uint uDeviceID, IntPtr dwCallback, IntPtr dwInstance, uint dwFlags);

		[DllImport("winmm.dll")]
		static extern uint midiOutShortMsg(IntPtr hMidiOut, uint dwMsg);

		[DllImport("winmm.dll")]
		static extern uint midiOutClose(IntPtr hMidiOut);

		private delegate void MidiCallBack(IntPtr handle, uint msg, uint instance, uint param1, uint param2);

		private static IntPtr Handle;

		public static void Enable()
		{
			//var result = midiOutOpen(out Handle, 0, IntPtr.Zero, IntPtr.Zero, 0);
			var result = midiOutOpen(out Handle, 0xFFFFFFFF, IntPtr.Zero, IntPtr.Zero, 0);

			//System.Diagnostics.Debug.WriteLine(result);
		}

		public static void NoteOn(int channel, int note, int velocity)
		{
			var result = midiOutShortMsg(Handle, 0x90u | (uint)channel | ((uint)note << 8) | ((uint)velocity << 16));

			//System.Diagnostics.Debug.WriteLine(result);
		}

		public static void NoteOff(int channel, int note, int velocity)
		{
			var result = midiOutShortMsg(Handle, 0x80u | (uint)channel | ((uint)note << 8) | ((uint)velocity << 16));

			//System.Diagnostics.Debug.WriteLine(result);
		}

		public static void ProgramChange(int channel, int patch)
		{
			var result = midiOutShortMsg(Handle, 0xC0u | (uint)channel | ((uint)patch << 8));

			//System.Diagnostics.Debug.WriteLine(result);
		}

		public static void ChannelPressure(int channel, int pressure)
		{
			var result = midiOutShortMsg(Handle, 0xD0u | (uint)channel | ((uint)pressure << 8));

			//System.Diagnostics.Debug.WriteLine(result);
		}

		public static void ControlChange(int channel, int control, int value)
		{
			var result = midiOutShortMsg(Handle, 0xB0u | (uint)channel | ((uint)control << 8) | ((uint)value << 16));

			//System.Diagnostics.Debug.WriteLine(result);
		}

		internal static void PitchBend(int channel, int value)
		{
			var result = midiOutShortMsg(Handle, 0xE0u | (uint)channel | (((uint)value & 0x7f) << 8) | (((uint)(value >> 7) & 0x7f) << 16));

			//System.Diagnostics.Debug.WriteLine(result);
		}

		public static void Disable()
		{
			var result = midiOutClose(Handle);

			//System.Diagnostics.Debug.WriteLine(result);
		}
	}
}
