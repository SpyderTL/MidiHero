using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiHero
{
	internal static class Menu
	{
		internal static MenuForm Form;

		internal static void Show()
		{
			Form = new MenuForm();

			Form.TrackListBox.SelectedIndexChanged += TrackListBox_SelectedIndexChanged;
			Form.ChannelsListBox.SelectedIndexChanged += ChannelsListBox_SelectedIndexChanged; ;
			Form.BrowseButton.Click += BrowseButton_Click;
			Form.StartButton.Click += StartButton_Click;

			Application.Run(Form);
		}

		private static void ChannelsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Form.InstrumentsListBox.Items.Clear();

			if ((int)Form.ChannelsListBox.SelectedItem == 9)
				Form.InstrumentsListBox.Items.Add("Drums");
			else
			{
				var patches = Song.Tracks[Form.TrackListBox.SelectedIndex].Events.Where(x => x.Channel == (int)Form.ChannelsListBox.SelectedItem && x.Type == Song.EventType.ProgramChange).Select(x => x.Value).Distinct().OrderBy(x => x).ToArray();

				Form.InstrumentsListBox.Items.AddRange(patches.Select(x => Instruments[x]).ToArray());
			}
		}

		private static void TrackListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Form.ChannelsListBox.Items.Clear();

			var channels = Song.Tracks[Form.TrackListBox.SelectedIndex].Events.Where(x => x.Type != Song.EventType.Delay).Select(x => x.Channel).Distinct().OrderBy(x => x).Cast<object>().ToArray();

			Form.ChannelsListBox.Items.AddRange(channels);

			if (Form.ChannelsListBox.Items.Count != 0)
				Form.ChannelsListBox.SelectedIndex = 0;
			else
				Form.InstrumentsListBox.Items.Clear();
		}

		private static void BrowseButton_Click(object sender, EventArgs e)
		{
			var dialog = new OpenFileDialog();

			dialog.Filter = "Midi Files (*.mid)|*.mid";
			dialog.FilterIndex = 1;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Form.MidiFileLabel.Text = dialog.FileName;

				MidiFile.Load(dialog.FileName);

				Form.TrackListBox.Items.Clear();

				for (var track = 0; track < Song.Tracks.Length; track++)
					Form.TrackListBox.Items.Add(Song.Tracks[track].Name ?? "Track " + track);

				if (Form.TrackListBox.Items.Count > 1)
					Form.TrackListBox.SelectedIndex = 1;
				else if (Form.TrackListBox.Items.Count == 1)
					Form.TrackListBox.SelectedIndex = 0;
			}
		}

		private static void StartButton_Click(object sender, EventArgs e)
		{
			if (Form.Speed50.Checked)
				SongPlayer.Speed = 0.5;
			else if (Form.Speed60.Checked)
				SongPlayer.Speed = 0.6;
			else if (Form.Speed70.Checked)
				SongPlayer.Speed = 0.7;
			else if (Form.Speed80.Checked)
				SongPlayer.Speed = 0.8;
			else if (Form.Speed90.Checked)
				SongPlayer.Speed = 0.9;
			else if (Form.Speed100.Checked)
				SongPlayer.Speed = 1.0;
			else if (Form.Speed125.Checked)
				SongPlayer.Speed = 1.25;
			else if (Form.Speed150.Checked)
				SongPlayer.Speed = 1.5;

			SongPlayer.Play();

			if (Form.GuitarButton.Checked)
			{
				Guitar.Tuning = new int[]
				{
					64,
					59,
					55,
					50,
					45,
					40
				};

				GuitarForm.Track = Form.TrackListBox.SelectedIndex;
				GuitarForm.Channel = (int)Form.ChannelsListBox.SelectedItem;
				GuitarForm.Show();
			}
			else if (Form.SevenStringButton.Checked)
			{
				Guitar.Tuning = new int[]
				{
					64,
					59,
					55,
					50,
					45,
					40,
					35,
				};

				GuitarForm.Track = Form.TrackListBox.SelectedIndex;
				GuitarForm.Channel = (int)Form.ChannelsListBox.SelectedItem;
				GuitarForm.Show();
			}
			else if (Form.EightStringButton.Checked)
			{
				Guitar.Tuning = new int[]
				{
					64,
					59,
					55,
					50,
					45,
					40,
					35,
					30
				};

				GuitarForm.Track = Form.TrackListBox.SelectedIndex;
				GuitarForm.Channel = (int)Form.ChannelsListBox.SelectedItem;
				GuitarForm.Show();
			}
			else if (Form.BassGuitarButton.Checked)
			{
				Guitar.Tuning = new int[]
				{
					43,
					38,
					33,
					28
				};

				GuitarForm.Track = Form.TrackListBox.SelectedIndex;
				GuitarForm.Channel = (int)Form.ChannelsListBox.SelectedItem;
				GuitarForm.Show();
			}
			else if (Form.FiveStringButton.Checked)
			{
				Guitar.Tuning = new int[]
				{
					43,
					38,
					33,
					28,
					23
				};

				GuitarForm.Track = Form.TrackListBox.SelectedIndex;
				GuitarForm.Channel = (int)Form.ChannelsListBox.SelectedItem;
				GuitarForm.Show();
			}
			else if (Form.KeyboardButton.Checked)
			{
				KeyboardForm.Track = Form.TrackListBox.SelectedIndex;
				KeyboardForm.Channel = (int)Form.ChannelsListBox.SelectedItem;
				KeyboardForm.Show();
			}
			else if (Form.DrumsButton.Checked)
			{
				DrumsForm.Track = Form.TrackListBox.SelectedIndex;
				DrumsForm.Channel = (int)Form.ChannelsListBox.SelectedItem;
				DrumsForm.Show();
			}
		}

		private static string[] Instruments = new string[]
		{
			"Acoustic Grand Piano",
			"Bright Acoustic Piano",
			"Electric Grand Piano",
			"Honky-tonk Piano",
			"Electric Piano 1",
			"Electric Piano 2",
			"Harpsichord",
			"Clavinet",
			"Celesta",
			"Glockenspiel",
			"Music Box",
			"Vibraphone",
			"Marimba",
			"Xylophone",
			"Tubular Bells",
			"Dulcimer",
			"Drawbar Organ",
			"Percussive Organ",
			"Rock Organ",
			"Church Organ",
			"Reed Organ",
			"Accordion",
			"Harmonica",
			"Tango Accordion",
			"Acoustic Guitar (nylon)",
			"Acoustic Guitar (steel)",
			"Electric Guitar (jazz)",
			"Electric Guitar (clean)",
			"Electric Guitar (muted)",
			"Overdriven Guitar",
			"Distortion Guitar",
			"Guitar harmonics",
			"Acoustic Bass",
			"Electric Bass (finger)",
			"Electric Bass (pick)",
			"Fretless Bass",
			"Slap Bass 1",
			"Slap Bass 2",
			"Synth Bass 1",
			"Synth Bass 2",
			"Violin",
			"Viola",
			"Cello",
			"Contrabass",
			"Tremolo Strings",
			"Pizzicato Strings",
			"Orchestral Harp",
			"Timpani",
			"String Ensemble 1",
			"String Ensemble 2",
			"Synth Strings 1",
			"Synth Strings 2",
			"Choir Aahs",
			"Voice Oohs",
			"Synth Voice",
			"Orchestra Hit",
			"Trumpet",
			"Trombone",
			"Tuba",
			"Muted Trumpet",
			"French Horn",
			"Brass Section",
			"Synth Brass 1",
			"Synth Brass 2",
			"Soprano Sax",
			"Alto Sax",
			"Tenor Sax",
			"Baritone Sax",
			"Oboe",
			"English Horn",
			"Bassoon",
			"Clarinet",
			"Piccolo",
			"Flute",
			"Recorder",
			"Pan Flute",
			"Blown Bottle",
			"Shakuhachi",
			"Whistle",
			"Ocarina",
			"Lead 1 (square)",
			"Lead 2 (sawtooth)",
			"Lead 3 (calliope)",
			"Lead 4 (chiff)",
			"Lead 5 (charang)",
			"Lead 6 (voice)",
			"Lead 7 (fifths)",
			"Lead 8 (bass + lead)",
			"Pad 1 (new age)",
			"Pad 2 (warm)",
			"Pad 3 (polysynth)",
			"Pad 4 (choir)",
			"Pad 5 (bowed)",
			"Pad 6 (metallic)",
			"Pad 7 (halo)",
			"Pad 8 (sweep)",
			"FX 1 (rain)",
			"FX 2 (soundtrack)",
			"FX 3 (crystal)",
			"FX 4 (atmosphere)",
			"FX 5 (brightness)",
			"FX 6 (goblins)",
			"FX 7 (echoes)",
			"FX 8 (sci-fi)",
			"Sitar",
			"Banjo",
			"Shamisen",
			"Koto",
			"Kalimba",
			"Bag pipe",
			"Fiddle",
			"Shanai",
			"Tinkle Bell",
			"Agogo",
			"Steel Drums",
			"Woodblock",
			"Taiko Drum",
			"Melodic Tom",
			"Synth Drum",
			"Reverse Cymbal",
			"Guitar Fret Noise",
			"Breath Noise",
			"Seashore",
			"Bird Tweet",
			"Telephone Ring",
			"Helicopter",
			"Applause",
			"Gunshot"
		};
	}
}
