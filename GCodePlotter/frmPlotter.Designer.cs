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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlotter));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(18, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(622, 469);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(646, 25);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(386, 469);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(646, 500);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Parse";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(727, 500);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// lstPlots
			// 
			this.lstPlots.FormattingEnabled = true;
			this.lstPlots.Location = new System.Drawing.Point(1038, 25);
			this.lstPlots.Name = "lstPlots";
			this.lstPlots.Size = new System.Drawing.Size(258, 459);
			this.lstPlots.TabIndex = 4;
			this.lstPlots.SelectedIndexChanged += new System.EventHandler(this.lstPlots_SelectedIndexChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(1038, 504);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(83, 17);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Render G0s";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// cmdShiftDown
			// 
			this.cmdShiftDown.Location = new System.Drawing.Point(1302, 260);
			this.cmdShiftDown.Name = "cmdShiftDown";
			this.cmdShiftDown.Size = new System.Drawing.Size(40, 30);
			this.cmdShiftDown.TabIndex = 6;
			this.cmdShiftDown.Text = "↓";
			this.cmdShiftDown.UseVisualStyleBackColor = true;
			this.cmdShiftDown.Click += new System.EventHandler(this.cmdShiftDown_Click);
			// 
			// cmdShiftUp
			// 
			this.cmdShiftUp.Location = new System.Drawing.Point(1302, 207);
			this.cmdShiftUp.Name = "cmdShiftUp";
			this.cmdShiftUp.Size = new System.Drawing.Size(40, 30);
			this.cmdShiftUp.TabIndex = 6;
			this.cmdShiftUp.Text = "↑";
			this.cmdShiftUp.UseVisualStyleBackColor = true;
			this.cmdShiftUp.Click += new System.EventHandler(this.cmdShiftUp_Click);
			// 
			// cmdToTop
			// 
			this.cmdToTop.Location = new System.Drawing.Point(1302, 151);
			this.cmdToTop.Name = "cmdToTop";
			this.cmdToTop.Size = new System.Drawing.Size(40, 30);
			this.cmdToTop.TabIndex = 7;
			this.cmdToTop.Text = "↑↑";
			this.cmdToTop.UseVisualStyleBackColor = true;
			this.cmdToTop.Click += new System.EventHandler(this.cmdToTop_Click);
			// 
			// cmdToBottom
			// 
			this.cmdToBottom.Location = new System.Drawing.Point(1302, 313);
			this.cmdToBottom.Name = "cmdToBottom";
			this.cmdToBottom.Size = new System.Drawing.Size(40, 30);
			this.cmdToBottom.TabIndex = 8;
			this.cmdToBottom.Text = "↓↓";
			this.cmdToBottom.UseVisualStyleBackColor = true;
			this.cmdToBottom.Click += new System.EventHandler(this.cmdToBottom_Click);
			// 
			// cmdLoad
			// 
			this.cmdLoad.Location = new System.Drawing.Point(18, 500);
			this.cmdLoad.Name = "cmdLoad";
			this.cmdLoad.Size = new System.Drawing.Size(85, 32);
			this.cmdLoad.TabIndex = 9;
			this.cmdLoad.Text = "Load Data";
			this.cmdLoad.UseVisualStyleBackColor = true;
			this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
			// 
			// cmdSave
			// 
			this.cmdSave.Location = new System.Drawing.Point(119, 500);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(85, 32);
			this.cmdSave.TabIndex = 9;
			this.cmdSave.Text = "Save Data";
			this.cmdSave.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(226, 500);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(114, 32);
			this.button3.TabIndex = 9;
			this.button3.Text = "Save Data (layers)";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// sfdSaveDialog
			// 
			this.sfdSaveDialog.DefaultExt = "gcode";
			this.sfdSaveDialog.Filter = "*.gcode|GCode Files|*.*|All Files";
			// 
			// ofdLoadDialog
			// 
			this.ofdLoadDialog.DefaultExt = "gcode";
			this.ofdLoadDialog.Filter = "*.gcode|GCode Files|*.*|All Files";
			// 
			// frmPlotter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1357, 546);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.cmdSave);
			this.Controls.Add(this.cmdLoad);
			this.Controls.Add(this.cmdToBottom);
			this.Controls.Add(this.cmdToTop);
			this.Controls.Add(this.cmdShiftUp);
			this.Controls.Add(this.cmdShiftDown);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.lstPlots);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmPlotter";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmPlotter_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

