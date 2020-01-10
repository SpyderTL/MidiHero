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

		[DllImport("winmm.dll", SetLastError = true)]
		static extern uint midiOutGetNumDevs();

		[DllImport("winmm.dll", SetLastError = true)]
		static extern MMRESULT midiOutGetDevCaps(UIntPtr uDeviceID, ref MIDIOUTCAPS lpMidiOutCaps, uint cbMidiOutCaps);

		delegate void MidiCallBack(IntPtr handle, uint msg, uint instance, uint param1, uint param2);

		static IntPtr Handle;

		public static int Device;

		public static Tuple<uint, string>[] Devices = new Tuple<uint, string>[0];

		public static void Refresh()
		{
			var count = midiOutGetNumDevs();

			Devices = new Tuple<uint, string>[count + 1];

			var caps = new MIDIOUTCAPS();

			midiOutGetDevCaps((UIntPtr)0xffffffff, ref caps, (uint)Marshal.SizeOf(typeof(MIDIOUTCAPS)));

			Devices[0] = new Tuple<uint, string>(0xffffffff, caps.szPname);

			for (uint x = 0; x < count; x++)
			{
				midiOutGetDevCaps((UIntPtr)x, ref caps, (uint)Marshal.SizeOf(typeof(MIDIOUTCAPS)));

				Devices[x + 1] = new Tuple<uint, string>(x, caps.szPname);
			}
		}

		public static void Enable()
		{
			var result = midiOutOpen(out Handle, Devices[Device].Item1, IntPtr.Zero, IntPtr.Zero, 0);
		}

		public static void NoteOn(int channel, int note, int velocity)
		{
			var result = midiOutShortMsg(Handle, 0x90u | (uint)channel | ((uint)note << 8) | ((uint)velocity << 16));
		}

		public static void NoteOff(int channel, int note, int velocity)
		{
			var result = midiOutShortMsg(Handle, 0x80u | (uint)channel | ((uint)note << 8) | ((uint)velocity << 16));
		}

		public static void KeyPressure(int channel, int note, int velocity)
		{
			var result = midiOutShortMsg(Handle, 0xA0u | (uint)channel | ((uint)note << 8) | ((uint)velocity << 16));
		}

		public static void ProgramChange(int channel, int patch)
		{
			var result = midiOutShortMsg(Handle, 0xC0u | (uint)channel | ((uint)patch << 8));
		}

		public static void ChannelPressure(int channel, int pressure)
		{
			var result = midiOutShortMsg(Handle, 0xD0u | (uint)channel | ((uint)pressure << 8));
		}

		public static void ControlChange(int channel, int control, int value)
		{
			var result = midiOutShortMsg(Handle, 0xB0u | (uint)channel | ((uint)control << 8) | ((uint)value << 16));
		}

		internal static void PitchBend(int channel, int value)
		{
			var result = midiOutShortMsg(Handle, 0xE0u | (uint)channel | (((uint)value & 0x7f) << 8) | (((uint)(value >> 7) & 0x7f) << 16));
		}

		public static void Disable()
		{
			var result = midiOutClose(Handle);
		}

		[StructLayout(LayoutKind.Sequential)]
		struct MIDIOUTCAPS
		{
			public ushort wMid;
			public ushort wPid;
			public uint vDriverVersion;     //MMVERSION
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string szPname;
			public ushort wTechnology;
			public ushort wVoices;
			public ushort wNotes;
			public ushort wChannelMask;
			public uint dwSupport;
		}

		// values for wTechnology field of MIDIOUTCAPS structure
		const ushort MOD_MIDIPORT = 1;     // output port
		const ushort MOD_SYNTH = 2;        // generic internal synth
		const ushort MOD_SQSYNTH = 3;      // square wave internal synth
		const ushort MOD_FMSYNTH = 4;      // FM internal synth
		const ushort MOD_MAPPER = 5;       // MIDI mapper
		const ushort MOD_WAVETABLE = 6;    // hardware wavetable synth
		const ushort MOD_SWSYNTH = 7;      // software synth

		// flags for dwSupport field of MIDIOUTCAPS structure
		const uint MIDICAPS_VOLUME = 1;      // supports volume control
		const uint MIDICAPS_LRVOLUME = 2;    // separate left-right volume control
		const uint MIDICAPS_CACHE = 4;
		const uint MIDICAPS_STREAM = 8;      // driver supports midiStreamOut directly

		enum MMRESULT : uint
		{
			MMSYSERR_NOERROR = 0,
			MMSYSERR_ERROR = 1,
			MMSYSERR_BADDEVICEID = 2,
			MMSYSERR_NOTENABLED = 3,
			MMSYSERR_ALLOCATED = 4,
			MMSYSERR_INVALHANDLE = 5,
			MMSYSERR_NODRIVER = 6,
			MMSYSERR_NOMEM = 7,
			MMSYSERR_NOTSUPPORTED = 8,
			MMSYSERR_BADERRNUM = 9,
			MMSYSERR_INVALFLAG = 10,
			MMSYSERR_INVALPARAM = 11,
			MMSYSERR_HANDLEBUSY = 12,
			MMSYSERR_INVALIDALIAS = 13,
			MMSYSERR_BADDB = 14,
			MMSYSERR_KEYNOTFOUND = 15,
			MMSYSERR_READERROR = 16,
			MMSYSERR_WRITEERROR = 17,
			MMSYSERR_DELETEERROR = 18,
			MMSYSERR_VALNOTFOUND = 19,
			MMSYSERR_NODRIVERCB = 20,
			WAVERR_BADFORMAT = 32,
			WAVERR_STILLPLAYING = 33,
			WAVERR_UNPREPARED = 34
		}
	}
}
