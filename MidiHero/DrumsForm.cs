﻿using System;
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
		internal static Ellipse[] Panels;
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

			Form.Text = Song.Name + " - Midi Hero v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
			Form.SpeedLabel.Text = "Speed: " + SongPlayer.Speed.ToString("P0");

			Form.FormClosing += Form_FormClosing;
			Form.PlayButton.Click += PlayButton_Click;
			Form.PauseButton.Click += PauseButton_Click;
			Form.RestartButton.Click += RestartButton_Click;
			Form.IncreaseSpeedButton.Click += IncreaseSpeedButton_Click;
			Form.DecreaseSpeedButton.Click += DecreaseSpeedButton_Click;

			Panels = new Ellipse[8];

			// Bass Drum
			Panels[0] = new Ellipse();

			Panels[0].Location = new Point(412, 500);
			Panels[0].Size = new Size(180, 180);
			Panels[0].ForeColor = Color.Gray;

			Form.Controls.Add(Panels[0]);

			// Snare Drum
			Panels[1] = new Ellipse();

			Panels[1].Location = new Point(430, 430);
			Panels[1].Size = new Size(120, 60);
			Panels[1].ForeColor = Color.Gray;

			Form.Controls.Add(Panels[1]);

			// Tom 1
			Panels[2] = new Ellipse();

			Panels[2].Location = new Point(410, 340);
			Panels[2].Size = new Size(80, 55);
			Panels[2].ForeColor = Color.Gray;

			Form.Controls.Add(Panels[2]);

			// Tom 2
			Panels[3] = new Ellipse();

			Panels[3].Location = new Point(510, 350);
			Panels[3].Size = new Size(100, 70);
			Panels[3].ForeColor = Color.Gray;

			Form.Controls.Add(Panels[3]);

			// Tom 3
			Panels[4] = new Ellipse();

			Panels[4].Location = new Point(600, 440);
			Panels[4].Size = new Size(140, 90);
			Panels[4].ForeColor = Color.Gray;

			Form.Controls.Add(Panels[4]);

			// Hi Hat
			Panels[5] = new Ellipse();

			Panels[5].Location = new Point(300, 450);
			Panels[5].Size = new Size(100, 35);
			Panels[5].ForeColor = Color.Gray;

			Form.Controls.Add(Panels[5]);

			// Crash Cymbal
			Panels[6] = new Ellipse();

			Panels[6].Location = new Point(305, 270);
			Panels[6].Size = new Size(150, 30);
			Panels[6].ForeColor = Color.Gray;

			Form.Controls.Add(Panels[6]);

			// Ride Cymbal
			Panels[7] = new Ellipse();

			Panels[7].Location = new Point(545, 270);
			Panels[7].Size = new Size(150, 30);
			Panels[7].ForeColor = Color.Gray;

			Form.Controls.Add(Panels[7]);

			Form.Show();

			Next = 0;

			Timer = new System.Threading.Timer(Timer_Callback, null, TimeSpan.Zero, TimeSpan.FromMilliseconds(5));
		}

		private static void PlayButton_Click(object sender, EventArgs e)
		{
			Form.PlayButton.Visible = false;
			Form.PauseButton.Visible = true;

			SongPlayer.Resume();
		}

		private static void PauseButton_Click(object sender, EventArgs e)
		{
			Form.PauseButton.Visible = false;
			Form.PlayButton.Visible = true;

			SongPlayer.Pause();
		}

		private static void RestartButton_Click(object sender, EventArgs e)
		{
			SongPlayer.Stop();

			for (var x = 0; x < Panels.Length; x++)
			{
				Panels[x].ForeColor = Color.Gray;
				Timers[x] = 0.0;
			}

			HiHat = false;
			Rim = false;
			Bell = false;
			China = false;

			Next = 0;

			SongPlayer.Play();
		}

		private static void IncreaseSpeedButton_Click(object sender, EventArgs e)
		{
			SongPlayer.Speed += 0.1;

			Form.SpeedLabel.Text = "Speed: " + SongPlayer.Speed.ToString("P0");
		}

		private static void DecreaseSpeedButton_Click(object sender, EventArgs e)
		{
			if (SongPlayer.Speed < 0.1)
				return;

			SongPlayer.Speed -= 0.1;

			Form.SpeedLabel.Text = "Speed: " + SongPlayer.Speed.ToString("P0");
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
						Panels[drum].ForeColor = Color.Gray;
					else if (drum == 5 && HiHat)
						Panels[drum].ForeColor = Color.FromArgb(128 - color, 128 - color, 128 + color);
					else if (drum == 1 && Rim)
						Panels[drum].ForeColor = Color.FromArgb(128 - color, 128 - color, 128 + color);
					else if (drum == 6 && China)
						Panels[drum].ForeColor = Color.FromArgb(128 - color, 128 - color, 128 + color);
					else if (drum == 7 && Bell)
						Panels[drum].ForeColor = Color.FromArgb(128 - color, 128 - color, 128 + color);
					else
						Panels[drum].ForeColor = Color.FromArgb(128 - color, 128 + color, 128 - color);
				}
			}
		}

		internal class Ellipse : PictureBox
		{
			public Ellipse()
			{
				BackColor = Color.Transparent;
			}

			protected override void OnPaint(PaintEventArgs e)
			{
				var brush = new SolidBrush(ForeColor);

				//e.Graphics.FillRectangle(brush, e.ClipRectangle);

				//brush.Color = ForeColor;

				e.Graphics.FillEllipse(brush, DisplayRectangle);

				brush.Dispose();

				//base.OnPaint(e);
			}

			//protected override void OnPaintBackground(PaintEventArgs e)
			//{
			//	//var brush = new SolidBrush(BackColor);

			//	//e.Graphics.FillRectangle(brush, e.ClipRectangle);

			//	//brush.Color = ForeColor;

			//	//e.Graphics.FillEllipse(brush, e.ClipRectangle);

			//	//brush.Dispose();
			//}
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
