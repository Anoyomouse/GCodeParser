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
			this.cmdShiftDown.Size = new System.Drawing.Size(31, 30);
			this.cmdShiftDown.TabIndex = 6;
			this.cmdShiftDown.Text = "↓";
			this.cmdShiftDown.UseVisualStyleBackColor = true;
			this.cmdShiftDown.Click += new System.EventHandler(this.cmdShiftDown_Click);
			// 
			// cmdShiftUp
			// 
			this.cmdShiftUp.Location = new System.Drawing.Point(1302, 207);
			this.cmdShiftUp.Name = "cmdShiftUp";
			this.cmdShiftUp.Size = new System.Drawing.Size(31, 30);
			this.cmdShiftUp.TabIndex = 6;
			this.cmdShiftUp.Text = "↑";
			this.cmdShiftUp.UseVisualStyleBackColor = true;
			this.cmdShiftUp.Click += new System.EventHandler(this.cmdShiftUp_Click);
			// 
			// frmPlotter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1345, 546);
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
    }
}

