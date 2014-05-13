namespace GCodePlotter
{
    partial class frmPlotter
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.lstPlots = new System.Windows.Forms.ListBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.cmdShiftDown = new System.Windows.Forms.Button();
			this.cmdShiftUp = new System.Windows.Forms.Button();
			this.cmdToTop = new System.Windows.Forms.Button();
			this.cmdToBottom = new System.Windows.Forms.Button();
			this.cmdLoad = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.sfdSaveDialog = new System.Windows.Forms.SaveFileDialog();
			this.ofdLoadDialog = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txtFile = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(5, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(596, 508);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(10, 212);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Parse";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(10, 250);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// lstPlots
			// 
			this.lstPlots.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstPlots.FormattingEnabled = true;
			this.lstPlots.Location = new System.Drawing.Point(0, 0);
			this.lstPlots.Name = "lstPlots";
			this.lstPlots.Size = new System.Drawing.Size(265, 475);
			this.lstPlots.TabIndex = 4;
			this.lstPlots.SelectedIndexChanged += new System.EventHandler(this.lstPlots_SelectedIndexChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(7, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(83, 17);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Render G0s";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// cmdShiftDown
			// 
			this.cmdShiftDown.Location = new System.Drawing.Point(7, 235);
			this.cmdShiftDown.Name = "cmdShiftDown";
			this.cmdShiftDown.Size = new System.Drawing.Size(40, 30);
			this.cmdShiftDown.TabIndex = 6;
			this.cmdShiftDown.Text = "↓";
			this.cmdShiftDown.UseVisualStyleBackColor = true;
			this.cmdShiftDown.Click += new System.EventHandler(this.cmdShiftDown_Click);
			// 
			// cmdShiftUp
			// 
			this.cmdShiftUp.Location = new System.Drawing.Point(7, 182);
			this.cmdShiftUp.Name = "cmdShiftUp";
			this.cmdShiftUp.Size = new System.Drawing.Size(40, 30);
			this.cmdShiftUp.TabIndex = 6;
			this.cmdShiftUp.Text = "↑";
			this.cmdShiftUp.UseVisualStyleBackColor = true;
			this.cmdShiftUp.Click += new System.EventHandler(this.cmdShiftUp_Click);
			// 
			// cmdToTop
			// 
			this.cmdToTop.Location = new System.Drawing.Point(7, 126);
			this.cmdToTop.Name = "cmdToTop";
			this.cmdToTop.Size = new System.Drawing.Size(40, 30);
			this.cmdToTop.TabIndex = 7;
			this.cmdToTop.Text = "↑↑";
			this.cmdToTop.UseVisualStyleBackColor = true;
			this.cmdToTop.Click += new System.EventHandler(this.cmdToTop_Click);
			// 
			// cmdToBottom
			// 
			this.cmdToBottom.Location = new System.Drawing.Point(7, 288);
			this.cmdToBottom.Name = "cmdToBottom";
			this.cmdToBottom.Size = new System.Drawing.Size(40, 30);
			this.cmdToBottom.TabIndex = 8;
			this.cmdToBottom.Text = "↓↓";
			this.cmdToBottom.UseVisualStyleBackColor = true;
			this.cmdToBottom.Click += new System.EventHandler(this.cmdToBottom_Click);
			// 
			// cmdLoad
			// 
			this.cmdLoad.Location = new System.Drawing.Point(10, 21);
			this.cmdLoad.Name = "cmdLoad";
			this.cmdLoad.Size = new System.Drawing.Size(85, 32);
			this.cmdLoad.TabIndex = 9;
			this.cmdLoad.Text = "Load Data";
			this.cmdLoad.UseVisualStyleBackColor = true;
			this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
			// 
			// cmdSave
			// 
			this.cmdSave.Location = new System.Drawing.Point(10, 59);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(85, 32);
			this.cmdSave.TabIndex = 9;
			this.cmdSave.Text = "Save Data";
			this.cmdSave.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(10, 97);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(114, 32);
			this.button3.TabIndex = 9;
			this.button3.Text = "Save Data (layers)";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// sfdSaveDialog
			// 
			this.sfdSaveDialog.DefaultExt = "gcode";
			this.sfdSaveDialog.Filter = "GCode Files|*.gcode|All Files|*.*";
			// 
			// ofdLoadDialog
			// 
			this.ofdLoadDialog.DefaultExt = "gcode";
			this.ofdLoadDialog.Filter = "GCode Files|*.gcode|All Files|*.*";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lstPlots);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(772, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(324, 508);
			this.panel1.TabIndex = 10;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.checkBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 475);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(324, 33);
			this.panel2.TabIndex = 9;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.cmdToBottom);
			this.panel3.Controls.Add(this.cmdToTop);
			this.panel3.Controls.Add(this.cmdShiftUp);
			this.panel3.Controls.Add(this.cmdShiftDown);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(265, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(59, 475);
			this.panel3.TabIndex = 10;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.txtFile);
			this.panel4.Controls.Add(this.button3);
			this.panel4.Controls.Add(this.cmdSave);
			this.panel4.Controls.Add(this.cmdLoad);
			this.panel4.Controls.Add(this.button2);
			this.panel4.Controls.Add(this.button1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(601, 5);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(171, 508);
			this.panel4.TabIndex = 11;
			// 
			// txtFile
			// 
			this.txtFile.Location = new System.Drawing.Point(6, 182);
			this.txtFile.Name = "txtFile";
			this.txtFile.ReadOnly = true;
			this.txtFile.Size = new System.Drawing.Size(143, 20);
			this.txtFile.TabIndex = 10;
			this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
			// 
			// frmPlotter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1101, 518);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Name = "frmPlotter";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmPlotter_Load);
			this.ResizeEnd += new System.EventHandler(this.frmPlotter_ResizeEnd);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListBox lstPlots;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button cmdShiftDown;
		private System.Windows.Forms.Button cmdShiftUp;
		private System.Windows.Forms.Button cmdToTop;
		private System.Windows.Forms.Button cmdToBottom;
		private System.Windows.Forms.Button cmdLoad;
		private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.SaveFileDialog sfdSaveDialog;
		private System.Windows.Forms.OpenFileDialog ofdLoadDialog;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox txtFile;
    }
}

