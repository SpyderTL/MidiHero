using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiHero
{
	internal static class DrumsForm
	{
		internal static SongForm Form;
		internal static int Track;
		internal static int Channel;
		internal static int Next;
		internal static Panel[] Panels;
		internal static System.Threading.Timer Timer;

		internal static void Show()
		{
			Form = new SongForm();

			Form.Text = Song.Name + " - Midi Hero v1.0";

			Form.FormClosing += Form_FormClosing;

			Form.Show();

			Panels = new Panel[32];

			for (var x = 0; x < Panels.Length; x++)
			{
				var panel = new Panel();

				panel.Location = new Point(20, 280);
				panel.Size = new Size(19, 100);
				panel.BackColor = Color.White;

				Form.Controls.Add(panel);

				Panels[x] = panel;
			}

			Next = 0;

			Timer = new System.Threading.Timer(Timer_Callback, null, TimeSpan.Zero, TimeSpan.FromMilliseconds(10));
		}

		private static void Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			SongPlayer.Stop();

			Timer.Change(-1, -1);
			Timer.Dispose();

			Form = null;
		}

		private static void Timer_Callback(object state)
		{
			try
			{
				if (Form != null &&
					!Form.Disposing &&
					!Form.IsDisposed)
					Form.Invoke((Action)Update);
			}
			catch (Exception)
			{
			}
		}

		internal static void Hide()
		{
			Form.Hide();

			Form.Dispose();
			Form = null;
		}

		internal static void Update()
		{
			while (Next < SongPlayer.Next[Track])
			{
				var e = Song.Tracks[Track].Events[Next];

				if (e.Channel == Channel)
				{
					for (int x = 0; x < Panels.Length; x++)
					{
						if (e.Type == Song.EventType.NoteOn)
						{
							Panels[x].BackColor = e.Value2 != 0 ? Color.Lime : Color.Gray;
						}
						else if (e.Type == Song.EventType.NoteOff)
						{
							Panels[x].BackColor = Color.Gray;
						}
					}
				}

				Next++;
			}
		}

		internal class Ellipse : Panel
		{
			protected override void OnPaintBackground(PaintEventArgs e)
			{
				var brush = new SolidBrush(BackColor);

				e.Graphics.FillEllipse(brush, e.ClipRectangle);

				brush.Dispose();
			}
		}
	}
}
