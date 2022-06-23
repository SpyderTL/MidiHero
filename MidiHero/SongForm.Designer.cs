namespace MidiHero
{
	partial class SongForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.RestartButton = new System.Windows.Forms.ToolStripButton();
			this.PlayButton = new System.Windows.Forms.ToolStripButton();
			this.PauseButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.SpeedLabel = new System.Windows.Forms.ToolStripLabel();
			this.IncreaseSpeedButton = new System.Windows.Forms.ToolStripButton();
			this.DecreaseSpeedButton = new System.Windows.Forms.ToolStripButton();
			this.LyricsTextBox = new System.Windows.Forms.TextBox();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestartButton,
            this.PlayButton,
            this.PauseButton,
            this.toolStripSeparator1,
            this.SpeedLabel,
            this.IncreaseSpeedButton,
            this.DecreaseSpeedButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 716);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1008, 31);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// RestartButton
			// 
			this.RestartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.RestartButton.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.RestartButton.Image = ((System.Drawing.Image)(resources.GetObject("RestartButton.Image")));
			this.RestartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.RestartButton.Name = "RestartButton";
			this.RestartButton.Size = new System.Drawing.Size(35, 28);
			this.RestartButton.Text = "9";
			this.RestartButton.ToolTipText = "Restart";
			// 
			// PlayButton
			// 
			this.PlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.PlayButton.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
			this.PlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new System.Drawing.Size(35, 28);
			this.PlayButton.Text = "4";
			this.PlayButton.ToolTipText = "Resume";
			this.PlayButton.Visible = false;
			// 
			// PauseButton
			// 
			this.PauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.PauseButton.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.PauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PauseButton.Image")));
			this.PauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PauseButton.Name = "PauseButton";
			this.PauseButton.Size = new System.Drawing.Size(35, 28);
			this.PauseButton.Text = ";";
			this.PauseButton.ToolTipText = "Pause";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// SpeedLabel
			// 
			this.SpeedLabel.Name = "SpeedLabel";
			this.SpeedLabel.Size = new System.Drawing.Size(73, 28);
			this.SpeedLabel.Text = "Speed: 100%";
			// 
			// IncreaseSpeedButton
			// 
			this.IncreaseSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.IncreaseSpeedButton.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.IncreaseSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("IncreaseSpeedButton.Image")));
			this.IncreaseSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.IncreaseSpeedButton.Name = "IncreaseSpeedButton";
			this.IncreaseSpeedButton.Size = new System.Drawing.Size(35, 28);
			this.IncreaseSpeedButton.Text = "5";
			this.IncreaseSpeedButton.ToolTipText = "Increase Speed";
			// 
			// DecreaseSpeedButton
			// 
			this.DecreaseSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.DecreaseSpeedButton.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.DecreaseSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("DecreaseSpeedButton.Image")));
			this.DecreaseSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DecreaseSpeedButton.Name = "DecreaseSpeedButton";
			this.DecreaseSpeedButton.Size = new System.Drawing.Size(35, 28);
			this.DecreaseSpeedButton.Text = "6";
			this.DecreaseSpeedButton.ToolTipText = "Decrease Speed";
			// 
			// LyricsTextBox
			// 
			this.LyricsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LyricsTextBox.BackColor = System.Drawing.Color.Black;
			this.LyricsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LyricsTextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LyricsTextBox.ForeColor = System.Drawing.Color.White;
			this.LyricsTextBox.Location = new System.Drawing.Point(12, 12);
			this.LyricsTextBox.Multiline = true;
			this.LyricsTextBox.Name = "LyricsTextBox";
			this.LyricsTextBox.ReadOnly = true;
			this.LyricsTextBox.Size = new System.Drawing.Size(984, 108);
			this.LyricsTextBox.TabIndex = 1;
			this.LyricsTextBox.Visible = false;
			// 
			// SongForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1008, 747);
			this.Controls.Add(this.LyricsTextBox);
			this.Controls.Add(this.toolStrip1);
			this.DoubleBuffered = true;
			this.Name = "SongForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		public System.Windows.Forms.ToolStripButton RestartButton;
		public System.Windows.Forms.ToolStripButton PlayButton;
		public System.Windows.Forms.ToolStripButton PauseButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		public System.Windows.Forms.ToolStripButton IncreaseSpeedButton;
		public System.Windows.Forms.ToolStripButton DecreaseSpeedButton;
		public System.Windows.Forms.ToolStripLabel SpeedLabel;
		public System.Windows.Forms.TextBox LyricsTextBox;
	}
}