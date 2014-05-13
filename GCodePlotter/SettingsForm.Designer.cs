namespace GCodePlotter
{
	partial class SettingsForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.cpRapidMove = new ControlSuite.ColorPickerBox();
			this.cpNormalMove = new ControlSuite.ColorPickerBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cpCWArc = new ControlSuite.ColorPickerBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cpCCWArc = new ControlSuite.ColorPickerBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cpRapidMoveHighlight = new ControlSuite.ColorPickerBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cpLineHighlight = new ControlSuite.ColorPickerBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cpBackground = new ControlSuite.ColorPickerBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cpGridLines = new ControlSuite.ColorPickerBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmdClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Rapid Move";
			// 
			// cpRapidMove
			// 
			this.cpRapidMove.Location = new System.Drawing.Point(126, 9);
			this.cpRapidMove.Name = "cpRapidMove";
			this.cpRapidMove.SelectedColor = System.Drawing.Color.Red;
			this.cpRapidMove.Size = new System.Drawing.Size(98, 20);
			this.cpRapidMove.TabIndex = 1;
			// 
			// cpNormalMove
			// 
			this.cpNormalMove.Location = new System.Drawing.Point(126, 35);
			this.cpNormalMove.Name = "cpNormalMove";
			this.cpNormalMove.SelectedColor = System.Drawing.Color.DodgerBlue;
			this.cpNormalMove.Size = new System.Drawing.Size(98, 20);
			this.cpNormalMove.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Normal Move";
			// 
			// cpCWArc
			// 
			this.cpCWArc.Location = new System.Drawing.Point(126, 61);
			this.cpCWArc.Name = "cpCWArc";
			this.cpCWArc.SelectedColor = System.Drawing.Color.Lime;
			this.cpCWArc.Size = new System.Drawing.Size(98, 20);
			this.cpCWArc.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(76, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "CW Arc";
			// 
			// cpCCWArc
			// 
			this.cpCCWArc.Location = new System.Drawing.Point(126, 87);
			this.cpCCWArc.Name = "cpCCWArc";
			this.cpCCWArc.SelectedColor = System.Drawing.Color.Yellow;
			this.cpCCWArc.Size = new System.Drawing.Size(98, 20);
			this.cpCCWArc.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(69, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "CCW Arc";
			// 
			// cpRapidMoveHighlight
			// 
			this.cpRapidMoveHighlight.Location = new System.Drawing.Point(126, 113);
			this.cpRapidMoveHighlight.Name = "cpRapidMoveHighlight";
			this.cpRapidMoveHighlight.SelectedColor = System.Drawing.Color.Salmon;
			this.cpRapidMoveHighlight.Size = new System.Drawing.Size(98, 20);
			this.cpRapidMoveHighlight.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Rapid Move Highlight";
			// 
			// cpLineHighlight
			// 
			this.cpLineHighlight.Location = new System.Drawing.Point(126, 139);
			this.cpLineHighlight.Name = "cpLineHighlight";
			this.cpLineHighlight.SelectedColor = System.Drawing.Color.White;
			this.cpLineHighlight.Size = new System.Drawing.Size(98, 20);
			this.cpLineHighlight.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(49, 142);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Line Highlight";
			// 
			// cpBackground
			// 
			this.cpBackground.Location = new System.Drawing.Point(126, 165);
			this.cpBackground.Name = "cpBackground";
			this.cpBackground.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.cpBackground.Size = new System.Drawing.Size(98, 20);
			this.cpBackground.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(55, 168);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Background";
			// 
			// cpGridLines
			// 
			this.cpGridLines.Location = new System.Drawing.Point(126, 191);
			this.cpGridLines.Name = "cpGridLines";
			this.cpGridLines.SelectedColor = System.Drawing.Color.DimGray;
			this.cpGridLines.Size = new System.Drawing.Size(98, 20);
			this.cpGridLines.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(66, 194);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Grid Lines";
			// 
			// cmdClose
			// 
			this.cmdClose.Location = new System.Drawing.Point(58, 219);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(106, 34);
			this.cmdClose.TabIndex = 16;
			this.cmdClose.Text = "Close";
			this.cmdClose.UseVisualStyleBackColor = true;
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(235, 265);
			this.Controls.Add(this.cmdClose);
			this.Controls.Add(this.cpGridLines);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cpBackground);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cpLineHighlight);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cpRapidMoveHighlight);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cpCCWArc);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cpCWArc);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cpNormalMove);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cpRapidMove);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "SettingsForm";
			this.Text = "SettingsForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private ControlSuite.ColorPickerBox cpRapidMove;
		private ControlSuite.ColorPickerBox cpNormalMove;
		private ControlSuite.ColorPickerBox cpCWArc;
		private ControlSuite.ColorPickerBox cpCCWArc;
		private ControlSuite.ColorPickerBox cpRapidMoveHighlight;
		private ControlSuite.ColorPickerBox cpLineHighlight;
		private ControlSuite.ColorPickerBox cpBackground;
		private ControlSuite.ColorPickerBox cpGridLines;
		private System.Windows.Forms.Button cmdClose;

	}
}