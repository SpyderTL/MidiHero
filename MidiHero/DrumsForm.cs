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
		internal static double[] Timers = new double[8];
		internal static bool HiHat;
		internal static bool Rim;
		internal static bool Bell;
		internal static bool China;

		internal static void Show()
		{
			Power.AlwaysOn();

			Form = new SongForm();

			Form.Text = Song.Name + " - Midi Hero v1.0";

			Form.FormClosing += Form_FormClosing;

			Form.Show();

			Panels = new Panel[8];

			// Bass Drum
			Panels[0] = new Ellipse();

			Panels[0].Location = new Point(412, 500);
			Panels[0].Size = new Size(180, 180);
			Panels[0].BackColor = Color.Gray;

			Form.Controls.Add(Panels[0]);

			// Snare Drum
			Panels[1] = new Ellipse();

			Panels[1].Location = new Point(430, 430);
			Panels[1].Size = new Size(120, 60);
			Panels[1].BackColor = Color.Gray;

			Form.Controls.Add(Panels[1]);

			// Tom 1
			Panels[2] = new Ellipse();

			Panels[2].Location = new Point(410, 340);
			Panels[2].Size = new Size(80, 55);
			Panels[2].BackColor = Color.Gray;

			Form.Controls.Add(Panels[2]);

			// Tom 2
			Panels[3] = new Ellipse();

			Panels[3].Location = new Point(510, 350);
			Panels[3].Size = new Size(100, 70);
			Panels[3].BackColor = Color.Gray;

			Form.Controls.Add(Panels[3]);

			// Tom 3
			Panels[4] = new Ellipse();

			Panels[4].Location = new Point(600, 440);
			Panels[4].Size = new Size(140, 90);
			Panels[4].BackColor = Color.Gray;

			Form.Controls.Add(Panels[4]);

			// Hi Hat
			Panels[5] = new Ellipse();

			Panels[5].Location = new Point(300, 450);
			Panels[5].Size = new Size(100, 35);
			Panels[5].BackColor = Color.Gray;

			Form.Controls.Add(Panels[5]);

			// Crash Cymbal
			Panels[6] = new Ellipse();

			Panels[6].Location = new Point(305, 270);
			Panels[6].Size = new Size(150, 30);
			Panels[6].BackColor = Color.Gray;

			Form.Controls.Add(Panels[6]);

			// Ride Cymbal
			Panels[7] = new Ellipse();

			Panels[7].Location = new Point(545, 270);
			Panels[7].Size = new Size(150, 30);
			Panels[7].BackColor = Color.Gray;

			Form.Controls.Add(Panels[7]);

			Next = 0;

			Timer = new System.Threading.Timer(Timer_Callback, null, TimeSpan.Zero, TimeSpan.FromMilliseconds(5));
		}

		private static void Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			SongPlayer.Stop();

			Timer.Change(-1, -1);
			Timer.Dispose();

			Form = null;

			Power.Reset();
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
					//if (e.Type == Song.EventType.NoteOn)
					//	System.Diagnostics.Debug.WriteLine(e.Value);

					if (e.Value >= 35 &&
						e.Value < 60)
					{
						var drum = Drums[e.Value - 35];

						if (drum != -1)
						{
							if (e.Type == Song.EventType.NoteOn &&
								e.Value2 != 0)
							{
								Timers[drum] = 1.0;

								if (e.Value == 42)
									HiHat = false;
								else if (e.Value == 46)
									HiHat = true;
								else if (e.Value == 37)
									Rim = true;
								else if (e.Value == 38 ||
									e.Value == 40)
									Rim = false;
								else if (e.Value == 53)
									Bell = true;
								else if (e.Value == 51 ||
									e.Value == 59)
									Bell = false;
								else if (e.Value == 52)
									China = true;
								else if (e.Value == 49 ||
									e.Value == 57)
									China = false;
							}
						}
					}
				}

				Next++;
			}

			for (var drum = 0; drum < Timers.Length; drum++)
			{
				if (Timers[drum] > 0.0)
				{
					Timers[drum] -= 0.05;

					var color = (int)(Timers[drum] * 127.0);

					if (Timers[drum] <= 0.0)
						Panels[drum].BackColor = Color.Gray;
					else if (drum == 5 && HiHat)
						Panels[drum].BackColor = Color.FromArgb(128 - color, 128 - color, 128 + color);
					else if (drum == 1 && Rim)
						Panels[drum].BackColor = Color.FromArgb(128 - color, 128 - color, 128 + color);
					else if (drum == 6 && China)
						Panels[drum].BackColor = Color.FromArgb(128 - color, 128 - color, 128 + color);
					else if (drum == 7 && Bell)
						Panels[drum].BackColor = Color.FromArgb(128 - color, 128 - color, 128 + color);
					else
						Panels[drum].BackColor = Color.FromArgb(128 - color, 128 + color, 128 - color);
				}
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

		internal static int[] Drums = new int[]
		{
			0,
			0,
			1,
			1,
			-1,
			1,
			4,
			5,
			4,
			-1,
			3,
			5,
			3,
			2,
			6,
			2,
			7,
			6,
			7,
			-1,
			6,
			-1,
			6,
			-1,
			7
		};
	}
}
