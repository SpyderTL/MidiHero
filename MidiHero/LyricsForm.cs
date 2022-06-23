using System;
using System.Linq;
using System.Threading;

namespace MidiHero
{
	internal class LyricsForm
	{
		internal static Timer Timer = new Timer(Timer_Elapsed, null, Timeout.Infinite, Timeout.Infinite);
		internal static int Last;
		internal static SongForm Form;

		internal static void Enable()
		{
			Last = -1;
			Form.LyricsTextBox.Clear();

			Form.LyricsTextBox.Visible = true;
			Form.FormClosing += Form_FormClosing;

			Timer.Change(0, 50);
		}

		internal static void Disable()
		{
			Form.LyricsTextBox.Clear();

			Form.LyricsTextBox.Visible = false;

			Timer.Change(Timeout.Infinite, Timeout.Infinite);
		}

		private static void Form_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			Timer.Change(Timeout.Infinite, Timeout.Infinite);
		}

		private static void Timer_Elapsed(object state)
		{
			try
			{
				Form.Invoke((Action)Update);
			}
			catch (Exception)
			{
			}
		}

		private static void Update()
		{
			while (Last < SongPlayer.Word)
			{
				Last++;
				Form.LyricsTextBox.AppendText(SongPlayer.Lyrics[Last]);
			}
		}
	}
}