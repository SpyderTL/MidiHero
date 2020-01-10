namespace MidiHero
{
	partial class MenuForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BrowseButton = new System.Windows.Forms.Button();
			this.MidiFileLabel = new System.Windows.Forms.Label();
			this.StartButton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.TrackListBox = new System.Windows.Forms.ListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.FiveStringButton = new System.Windows.Forms.RadioButton();
			this.SevenStringButton = new System.Windows.Forms.RadioButton();
			this.EightStringButton = new System.Windows.Forms.RadioButton();
			this.DrumsButton = new System.Windows.Forms.RadioButton();
			this.KeyboardButton = new System.Windows.Forms.RadioButton();
			this.BassGuitarButton = new System.Windows.Forms.RadioButton();
			this.GuitarButton = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.ChannelsListBox = new System.Windows.Forms.ListBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.InstrumentsListBox = new System.Windows.Forms.ListBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.Speed150 = new System.Windows.Forms.RadioButton();
			this.Speed125 = new System.Windows.Forms.RadioButton();
			this.Speed100 = new System.Windows.Forms.RadioButton();
			this.Speed90 = new System.Windows.Forms.RadioButton();
			this.Speed80 = new System.Windows.Forms.RadioButton();
			this.Speed70 = new System.Windows.Forms.RadioButton();
			this.Speed60 = new System.Windows.Forms.RadioButton();
			this.Speed50 = new System.Windows.Forms.RadioButton();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.OutputListBox = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BrowseButton);
			this.groupBox1.Controls.Add(this.MidiFileLabel);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1008, 54);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Midi File";
			// 
			// BrowseButton
			// 
			this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BrowseButton.Location = new System.Drawing.Point(933, 12);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(69, 36);
			this.BrowseButton.TabIndex = 1;
			this.BrowseButton.Text = "&Browse";
			this.BrowseButton.UseVisualStyleBackColor = true;
			// 
			// MidiFileLabel
			// 
			this.MidiFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MidiFileLabel.AutoEllipsis = true;
			this.MidiFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MidiFileLabel.Location = new System.Drawing.Point(12, 16);
			this.MidiFileLabel.Name = "MidiFileLabel";
			this.MidiFileLabel.Size = new System.Drawing.Size(915, 25);
			this.MidiFileLabel.TabIndex = 0;
			this.MidiFileLabel.Text = "None";
			// 
			// StartButton
			// 
			this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartButton.Location = new System.Drawing.Point(891, 665);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(105, 52);
			this.StartButton.TabIndex = 2;
			this.StartButton.Text = "&Start";
			this.StartButton.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.TrackListBox);
			this.groupBox2.Location = new System.Drawing.Point(12, 60);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(188, 669);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tracks";
			// 
			// TrackListBox
			// 
			this.TrackListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TrackListBox.FormattingEnabled = true;
			this.TrackListBox.Location = new System.Drawing.Point(3, 16);
			this.TrackListBox.Name = "TrackListBox";
			this.TrackListBox.Size = new System.Drawing.Size(182, 650);
			this.TrackListBox.TabIndex = 4;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.FiveStringButton);
			this.groupBox3.Controls.Add(this.SevenStringButton);
			this.groupBox3.Controls.Add(this.EightStringButton);
			this.groupBox3.Controls.Add(this.DrumsButton);
			this.groupBox3.Controls.Add(this.KeyboardButton);
			this.groupBox3.Controls.Add(this.BassGuitarButton);
			this.groupBox3.Controls.Add(this.GuitarButton);
			this.groupBox3.Location = new System.Drawing.Point(206, 435);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(790, 176);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Instrument";
			// 
			// FiveStringButton
			// 
			this.FiveStringButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.FiveStringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FiveStringButton.Location = new System.Drawing.Point(162, 133);
			this.FiveStringButton.Name = "FiveStringButton";
			this.FiveStringButton.Size = new System.Drawing.Size(150, 36);
			this.FiveStringButton.TabIndex = 13;
			this.FiveStringButton.Text = "5 String";
			this.FiveStringButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.FiveStringButton.UseVisualStyleBackColor = true;
			// 
			// SevenStringButton
			// 
			this.SevenStringButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.SevenStringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SevenStringButton.Location = new System.Drawing.Point(6, 91);
			this.SevenStringButton.Name = "SevenStringButton";
			this.SevenStringButton.Size = new System.Drawing.Size(150, 36);
			this.SevenStringButton.TabIndex = 12;
			this.SevenStringButton.Text = "7 String";
			this.SevenStringButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SevenStringButton.UseVisualStyleBackColor = true;
			// 
			// EightStringButton
			// 
			this.EightStringButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.EightStringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EightStringButton.Location = new System.Drawing.Point(6, 133);
			this.EightStringButton.Name = "EightStringButton";
			this.EightStringButton.Size = new System.Drawing.Size(150, 36);
			this.EightStringButton.TabIndex = 11;
			this.EightStringButton.Text = "8 String";
			this.EightStringButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.EightStringButton.UseVisualStyleBackColor = true;
			// 
			// DrumsButton
			// 
			this.DrumsButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.DrumsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DrumsButton.Location = new System.Drawing.Point(474, 19);
			this.DrumsButton.Name = "DrumsButton";
			this.DrumsButton.Size = new System.Drawing.Size(150, 150);
			this.DrumsButton.TabIndex = 9;
			this.DrumsButton.Text = "Drums";
			this.DrumsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DrumsButton.UseVisualStyleBackColor = true;
			// 
			// KeyboardButton
			// 
			this.KeyboardButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.KeyboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.KeyboardButton.Location = new System.Drawing.Point(318, 19);
			this.KeyboardButton.Name = "KeyboardButton";
			this.KeyboardButton.Size = new System.Drawing.Size(150, 150);
			this.KeyboardButton.TabIndex = 8;
			this.KeyboardButton.Text = "Keyboard";
			this.KeyboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.KeyboardButton.UseVisualStyleBackColor = true;
			// 
			// BassGuitarButton
			// 
			this.BassGuitarButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.BassGuitarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BassGuitarButton.Location = new System.Drawing.Point(162, 19);
			this.BassGuitarButton.Name = "BassGuitarButton";
			this.BassGuitarButton.Size = new System.Drawing.Size(150, 108);
			this.BassGuitarButton.TabIndex = 7;
			this.BassGuitarButton.Text = "Bass Guitar";
			this.BassGuitarButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BassGuitarButton.UseVisualStyleBackColor = true;
			// 
			// GuitarButton
			// 
			this.GuitarButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.GuitarButton.Checked = true;
			this.GuitarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GuitarButton.Location = new System.Drawing.Point(6, 19);
			this.GuitarButton.Name = "GuitarButton";
			this.GuitarButton.Size = new System.Drawing.Size(150, 66);
			this.GuitarButton.TabIndex = 6;
			this.GuitarButton.TabStop = true;
			this.GuitarButton.Text = "Guitar";
			this.GuitarButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.GuitarButton.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Location = new System.Drawing.Point(212, 617);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(673, 100);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Options";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.ChannelsListBox);
			this.groupBox5.Location = new System.Drawing.Point(206, 60);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(188, 369);
			this.groupBox5.TabIndex = 8;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Channels";
			// 
			// ChannelsListBox
			// 
			this.ChannelsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChannelsListBox.FormattingEnabled = true;
			this.ChannelsListBox.Location = new System.Drawing.Point(3, 16);
			this.ChannelsListBox.Name = "ChannelsListBox";
			this.ChannelsListBox.Size = new System.Drawing.Size(182, 350);
			this.ChannelsListBox.TabIndex = 5;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.InstrumentsListBox);
			this.groupBox6.Location = new System.Drawing.Point(400, 60);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(188, 369);
			this.groupBox6.TabIndex = 9;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Instruments";
			// 
			// InstrumentsListBox
			// 
			this.InstrumentsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.InstrumentsListBox.FormattingEnabled = true;
			this.InstrumentsListBox.Location = new System.Drawing.Point(3, 16);
			this.InstrumentsListBox.Name = "InstrumentsListBox";
			this.InstrumentsListBox.Size = new System.Drawing.Size(182, 350);
			this.InstrumentsListBox.TabIndex = 5;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.Speed150);
			this.groupBox7.Controls.Add(this.Speed125);
			this.groupBox7.Controls.Add(this.Speed100);
			this.groupBox7.Controls.Add(this.Speed90);
			this.groupBox7.Controls.Add(this.Speed80);
			this.groupBox7.Controls.Add(this.Speed70);
			this.groupBox7.Controls.Add(this.Speed60);
			this.groupBox7.Controls.Add(this.Speed50);
			this.groupBox7.Location = new System.Drawing.Point(594, 60);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(188, 369);
			this.groupBox7.TabIndex = 10;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Speed";
			// 
			// Speed150
			// 
			this.Speed150.Appearance = System.Windows.Forms.Appearance.Button;
			this.Speed150.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Speed150.Location = new System.Drawing.Point(6, 313);
			this.Speed150.Name = "Speed150";
			this.Speed150.Size = new System.Drawing.Size(176, 36);
			this.Speed150.TabIndex = 21;
			this.Speed150.Text = "150%";
			this.Speed150.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Speed150.UseVisualStyleBackColor = true;
			// 
			// Speed125
			// 
			this.Speed125.Appearance = System.Windows.Forms.Appearance.Button;
			this.Speed125.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Speed125.Location = new System.Drawing.Point(6, 271);
			this.Speed125.Name = "Speed125";
			this.Speed125.Size = new System.Drawing.Size(176, 36);
			this.Speed125.TabIndex = 20;
			this.Speed125.Text = "125%";
			this.Speed125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Speed125.UseVisualStyleBackColor = true;
			// 
			// Speed100
			// 
			this.Speed100.Appearance = System.Windows.Forms.Appearance.Button;
			this.Speed100.Checked = true;
			this.Speed100.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Speed100.Location = new System.Drawing.Point(6, 229);
			this.Speed100.Name = "Speed100";
			this.Speed100.Size = new System.Drawing.Size(176, 36);
			this.Speed100.TabIndex = 19;
			this.Speed100.TabStop = true;
			this.Speed100.Text = "100%";
			this.Speed100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Speed100.UseVisualStyleBackColor = true;
			// 
			// Speed90
			// 
			this.Speed90.Appearance = System.Windows.Forms.Appearance.Button;
			this.Speed90.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Speed90.Location = new System.Drawing.Point(6, 187);
			this.Speed90.Name = "Speed90";
			this.Speed90.Size = new System.Drawing.Size(176, 36);
			this.Speed90.TabIndex = 18;
			this.Speed90.Text = "90%";
			this.Speed90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Speed90.UseVisualStyleBackColor = true;
			// 
			// Speed80
			// 
			this.Speed80.Appearance = System.Windows.Forms.Appearance.Button;
			this.Speed80.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Speed80.Location = new System.Drawing.Point(6, 145);
			this.Speed80.Name = "Speed80";
			this.Speed80.Size = new System.Drawing.Size(176, 36);
			this.Speed80.TabIndex = 17;
			this.Speed80.Text = "80%";
			this.Speed80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Speed80.UseVisualStyleBackColor = true;
			// 
			// Speed70
			// 
			this.Speed70.Appearance = System.Windows.Forms.Appearance.Button;
			this.Speed70.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Speed70.Location = new System.Drawing.Point(6, 103);
			this.Speed70.Name = "Speed70";
			this.Speed70.Size = new System.Drawing.Size(176, 36);
			this.Speed70.TabIndex = 16;
			this.Speed70.Text = "70%";
			this.Speed70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Speed70.UseVisualStyleBackColor = true;
			// 
			// Speed60
			// 
			this.Speed60.Appearance = System.Windows.Forms.Appearance.Button;
			this.Speed60.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Speed60.Location = new System.Drawing.Point(6, 61);
			this.Speed60.Name = "Speed60";
			this.Speed60.Size = new System.Drawing.Size(176, 36);
			this.Speed60.TabIndex = 15;
			this.Speed60.Text = "60%";
			this.Speed60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Speed60.UseVisualStyleBackColor = true;
			// 
			// Speed50
			// 
			this.Speed50.Appearance = System.Windows.Forms.Appearance.Button;
			this.Speed50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Speed50.Location = new System.Drawing.Point(6, 19);
			this.Speed50.Name = "Speed50";
			this.Speed50.Size = new System.Drawing.Size(176, 36);
			this.Speed50.TabIndex = 14;
			this.Speed50.Text = "50%";
			this.Speed50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Speed50.UseVisualStyleBackColor = true;
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.OutputListBox);
			this.groupBox8.Location = new System.Drawing.Point(788, 60);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(188, 369);
			this.groupBox8.TabIndex = 11;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Output";
			// 
			// OutputListBox
			// 
			this.OutputListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OutputListBox.FormattingEnabled = true;
			this.OutputListBox.Location = new System.Drawing.Point(3, 16);
			this.OutputListBox.Name = "OutputListBox";
			this.OutputListBox.Size = new System.Drawing.Size(182, 350);
			this.OutputListBox.TabIndex = 5;
			// 
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.groupBox8);
			this.Controls.Add(this.groupBox7);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.groupBox1);
			this.Name = "MenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Midi Hero v1.0";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		public System.Windows.Forms.Button BrowseButton;
		public System.Windows.Forms.Label MidiFileLabel;
		public System.Windows.Forms.Button StartButton;
		public System.Windows.Forms.ListBox TrackListBox;
		public System.Windows.Forms.RadioButton DrumsButton;
		public System.Windows.Forms.RadioButton KeyboardButton;
		public System.Windows.Forms.RadioButton BassGuitarButton;
		public System.Windows.Forms.RadioButton GuitarButton;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		public System.Windows.Forms.RadioButton SevenStringButton;
		public System.Windows.Forms.RadioButton EightStringButton;
		public System.Windows.Forms.RadioButton FiveStringButton;
		public System.Windows.Forms.ListBox ChannelsListBox;
		public System.Windows.Forms.ListBox InstrumentsListBox;
		private System.Windows.Forms.GroupBox groupBox7;
		public System.Windows.Forms.RadioButton Speed150;
		public System.Windows.Forms.RadioButton Speed125;
		public System.Windows.Forms.RadioButton Speed100;
		public System.Windows.Forms.RadioButton Speed90;
		public System.Windows.Forms.RadioButton Speed80;
		public System.Windows.Forms.RadioButton Speed70;
		public System.Windows.Forms.RadioButton Speed60;
		public System.Windows.Forms.RadioButton Speed50;
		private System.Windows.Forms.GroupBox groupBox8;
		public System.Windows.Forms.ListBox OutputListBox;
	}
}

