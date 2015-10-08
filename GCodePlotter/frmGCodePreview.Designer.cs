/**
 * Copyright (c) David-John Miller AKA Anoyomouse 2014
 *
 * See LICENCE in the project directory for licence information
 **/
namespace GCodePlotter
{
	partial class frmGCodePreview
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.radZoomSixteen = new System.Windows.Forms.RadioButton();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.radZoomEight = new System.Windows.Forms.RadioButton();
			this.radZoomFour = new System.Windows.Forms.RadioButton();
			this.radZoomTwo = new System.Windows.Forms.RadioButton();
			this.lstPlots = new System.Windows.Forms.ListBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(689, 599);
			this.panel1.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(418, 402);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.radZoomSixteen);
			this.panel5.Controls.Add(this.txtFile);
			this.panel5.Controls.Add(this.radZoomEight);
			this.panel5.Controls.Add(this.radZoomFour);
			this.panel5.Controls.Add(this.radZoomTwo);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(2, 563);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(424, 38);
			this.panel5.TabIndex = 14;
			// 
			// radZoomSixteen
			// 
			this.radZoomSixteen.AutoSize = true;
			this.radZoomSixteen.Location = new System.Drawing.Point(149, 12);
			this.radZoomSixteen.Name = "radZoomSixteen";
			this.radZoomSixteen.Size = new System.Drawing.Size(36, 17);
			this.radZoomSixteen.TabIndex = 0;
			this.radZoomSixteen.Text = "x4";
			this.radZoomSixteen.UseVisualStyleBackColor = true;
			this.radZoomSixteen.CheckedChanged += new System.EventHandler(this.chkChanged);
			// 
			// txtFile
			// 
			this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFile.Location = new System.Drawing.Point(201, 9);
			this.txtFile.Name = "txtFile";
			this.txtFile.ReadOnly = true;
			this.txtFile.Size = new System.Drawing.Size(207, 20);
			this.txtFile.TabIndex = 10;
			// 
			// radZoomEight
			// 
			this.radZoomEight.AutoSize = true;
			this.radZoomEight.Location = new System.Drawing.Point(107, 12);
			this.radZoomEight.Name = "radZoomEight";
			this.radZoomEight.Size = new System.Drawing.Size(36, 17);
			this.radZoomEight.TabIndex = 0;
			this.radZoomEight.Text = "x2";
			this.radZoomEight.UseVisualStyleBackColor = true;
			this.radZoomEight.CheckedChanged += new System.EventHandler(this.chkChanged);
			// 
			// radZoomFour
			// 
			this.radZoomFour.AutoSize = true;
			this.radZoomFour.Checked = true;
			this.radZoomFour.Location = new System.Drawing.Point(65, 12);
			this.radZoomFour.Name = "radZoomFour";
			this.radZoomFour.Size = new System.Drawing.Size(36, 17);
			this.radZoomFour.TabIndex = 0;
			this.radZoomFour.TabStop = true;
			this.radZoomFour.Text = "x1";
			this.radZoomFour.UseVisualStyleBackColor = true;
			this.radZoomFour.CheckedChanged += new System.EventHandler(this.chkChanged);
			// 
			// radZoomTwo
			// 
			this.radZoomTwo.AutoSize = true;
			this.radZoomTwo.Location = new System.Drawing.Point(14, 12);
			this.radZoomTwo.Name = "radZoomTwo";
			this.radZoomTwo.Size = new System.Drawing.Size(45, 17);
			this.radZoomTwo.TabIndex = 0;
			this.radZoomTwo.Text = "x0.5";
			this.radZoomTwo.UseVisualStyleBackColor = true;
			this.radZoomTwo.CheckedChanged += new System.EventHandler(this.chkChanged);
			// 
			// lstPlots
			// 
			this.lstPlots.Dock = System.Windows.Forms.DockStyle.Right;
			this.lstPlots.FormattingEnabled = true;
			this.lstPlots.Location = new System.Drawing.Point(426, 2);
			this.lstPlots.Name = "lstPlots";
			this.lstPlots.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstPlots.Size = new System.Drawing.Size(265, 599);
			this.lstPlots.TabIndex = 15;
			this.lstPlots.SelectedValueChanged += new System.EventHandler(this.lstPlots_SelectedValueChanged);
			// 
			// frmGCodePreview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 603);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.lstPlots);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmGCodePreview";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.Text = "GCode Preview";
			this.Load += new System.EventHandler(this.frmGCodePreview_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.RadioButton radZoomSixteen;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.RadioButton radZoomEight;
		private System.Windows.Forms.RadioButton radZoomFour;
		private System.Windows.Forms.RadioButton radZoomTwo;
		private System.Windows.Forms.ListBox lstPlots;
	}
}