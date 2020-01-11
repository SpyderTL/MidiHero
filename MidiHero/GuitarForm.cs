using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiHero
{
	internal static class GuitarForm
	{
		internal static SongForm Form;
		internal static int Track;
		internal static int Channel;
		internal static int Next;
		internal static Panel[,] Panels;
		internal static System.Threading.Timer Timer;

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

			Form.Show();

			Panels = new Panel[Guitar.Tuning.Length, 24];

			for (var x = 0; x < Guitar.Tuning.Length; x++)
			{
				for (var y = 0; y < 24; y++)
				{
					var panel = new Panel();

					panel.Location = new Point(y == 0 ? 32 : (y * 40) + 16, (x * 32) + 280);
					panel.Size = new Size(y == 0 ? 16 : 39, 31);

					panel.BackColor = Frets[y];

					Form.Controls.Add(panel);

					Panels[x, y] = panel;
				}
			}

			Next = 0;

			Timer = new System.Threading.Timer(Timer_Callback, null, TimeSpan.Zero, TimeSpan.FromMilliseconds(10));
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

			for (var x = 0; x < Guitar.Tuning.Length; x++)
				for (var y = 0; y < 24; y++)
					Panels[x, y].BackColor = Frets[y];

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
					for (int x = 0; x < Guitar.Tuning.Length; x++)
					{
						if (e.Type == Song.EventType.NoteOn)
						{
							if (e.Value >= Guitar.Tuning[x] &&
								e.Value < Guitar.Tuning[x] + 24)
							{
								Panels[x, e.Value - Guitar.Tuning[x]].BackColor = e.Value2 != 0 ? Color.Lime : Frets[e.Value - Guitar.Tuning[x]];
								//break;
							}
						}
						else if (e.Type == Song.EventType.NoteOff)
						{
							if (e.Value >= Guitar.Tuning[x] &&
								e.Value < Guitar.Tuning[x] + 24)
							{
								Panels[x, e.Value - Guitar.Tuning[x]].BackColor = Frets[e.Value - Guitar.Tuning[x]];
								//break;
							}
						}
					}
				}

				Next++;
			}
		}

		private static Color[] Frets = new Color[]
		{
			Color.SteelBlue,
			Color.Gray,
			Color.Gray,
			Color.SlateGray,
			Color.Gray,
			Color.SlateGray,
			Color.Gray,
			Color.SlateGray,
			Color.Gray,
			Color.SlateGray,
			Color.Gray,
			Color.Gray,
			Color.SteelBlue,
			Color.Gray,
			Color.Gray,
			Color.SlateGray,
			Color.Gray,
			Color.SlateGray,
			Color.Gray,
			Color.SlateGray,
			Color.Gray,
			Color.SlateGray,
			Color.Gray,
			Color.Gray,
		};
	}
}
