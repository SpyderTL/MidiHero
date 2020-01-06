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
			this.DrumsButton = new System.Windows.Forms.RadioButton();
			this.KeyboardButton = new System.Windows.Forms.RadioButton();
			this.BassGuitarButton = new System.Windows.Forms.RadioButton();
			this.GuitarButton = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.PauseCheckbox = new System.Windows.Forms.CheckBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.ChannelsListBox = new System.Windows.Forms.CheckedListBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.InstrumentsListBox = new System.Windows.Forms.CheckedListBox();
			this.EightStringButton = new System.Windows.Forms.RadioButton();
			this.SevenStringButton = new System.Windows.Forms.RadioButton();
			this.FiveStringButton = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
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
			// DrumsButton
			// 
			this.DrumsButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.DrumsButton.Enabled = false;
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
			this.groupBox4.Controls.Add(this.PauseCheckbox);
			this.groupBox4.Location = new System.Drawing.Point(212, 617);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(673, 100);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Options";
			// 
			// PauseCheckbox
			// 
			this.PauseCheckbox.AutoSize = true;
			this.PauseCheckbox.Location = new System.Drawing.Point(6, 19);
			this.PauseCheckbox.Name = "PauseCheckbox";
			this.PauseCheckbox.Size = new System.Drawing.Size(187, 17);
			this.PauseCheckbox.TabIndex = 0;
			this.PauseCheckbox.Text = "Wait for correct note to be played.";
			this.PauseCheckbox.UseVisualStyleBackColor = true;
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
			this.ChannelsListBox.TabIndex = 0;
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
			this.InstrumentsListBox.TabIndex = 0;
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
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
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
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
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
		public System.Windows.Forms.CheckBox PauseCheckbox;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		public System.Windows.Forms.CheckedListBox ChannelsListBox;
		public System.Windows.Forms.CheckedListBox InstrumentsListBox;
		public System.Windows.Forms.RadioButton SevenStringButton;
		public System.Windows.Forms.RadioButton EightStringButton;
		public System.Windows.Forms.RadioButton FiveStringButton;
	}
}

