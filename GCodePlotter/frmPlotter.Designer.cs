/**
 * Copyright (c) David-John Miller AKA Anoyomouse 2014
 *
 * See LICENCE in the project directory for licence information
 **/
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
			this.cmdParseData = new System.Windows.Forms.Button();
			this.cmdRedraw = new System.Windows.Forms.Button();
			this.lstPlots = new System.Windows.Forms.ListBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.cmdShiftDown = new System.Windows.Forms.Button();
			this.cmdShiftUp = new System.Windows.Forms.Button();
			this.cmdToTop = new System.Windows.Forms.Button();
			this.cmdToBottom = new System.Windows.Forms.Button();
			this.cmdLoad = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.cmdSaveLayers = new System.Windows.Forms.Button();
			this.sfdSaveDialog = new System.Windows.Forms.SaveFileDialog();
			this.ofdLoadDialog = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.cmdLayers = new System.Windows.Forms.Button();
			this.cmdShowGCode = new System.Windows.Forms.Button();
			this.cmdRenameSelection = new System.Windows.Forms.Button();
			this.cmdSettings = new System.Windows.Forms.Button();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.radZoomSixteen = new System.Windows.Forms.RadioButton();
			this.radZoomEight = new System.Windows.Forms.RadioButton();
			this.radZoomFour = new System.Windows.Forms.RadioButton();
			this.radZoomTwo = new System.Windows.Forms.RadioButton();
			this.panel6 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(721, 426);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// cmdParseData
			// 
			this.cmdParseData.Enabled = false;
			this.cmdParseData.Location = new System.Drawing.Point(10, 47);
			this.cmdParseData.Name = "cmdParseData";
			this.cmdParseData.Size = new System.Drawing.Size(102, 32);
			this.cmdParseData.TabIndex = 2;
			this.cmdParseData.Text = "Parse";
			this.cmdParseData.UseVisualStyleBackColor = true;
			this.cmdParseData.Click += new System.EventHandler(this.cmdParseData_Click);
			// 
			// cmdRedraw
			// 
			this.cmdRedraw.Location = new System.Drawing.Point(10, 176);
			this.cmdRedraw.Name = "cmdRedraw";
			this.cmdRedraw.Size = new System.Drawing.Size(102, 32);
			this.cmdRedraw.TabIndex = 2;
			this.cmdRedraw.Text = "Redraw";
			this.cmdRedraw.UseVisualStyleBackColor = true;
			this.cmdRedraw.Click += new System.EventHandler(this.cmdRedraw_Click);
			// 
			// lstPlots
			// 
			this.lstPlots.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstPlots.FormattingEnabled = true;
			this.lstPlots.Location = new System.Drawing.Point(0, 0);
			this.lstPlots.Name = "lstPlots";
			this.lstPlots.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstPlots.Size = new System.Drawing.Size(265, 476);
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
			this.cmdLoad.Location = new System.Drawing.Point(10, 9);
			this.cmdLoad.Name = "cmdLoad";
			this.cmdLoad.Size = new System.Drawing.Size(102, 32);
			this.cmdLoad.TabIndex = 9;
			this.cmdLoad.Text = "Load Data";
			this.cmdLoad.UseVisualStyleBackColor = true;
			this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
			// 
			// cmdSave
			// 
			this.cmdSave.Location = new System.Drawing.Point(10, 92);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(102, 32);
			this.cmdSave.TabIndex = 9;
			this.cmdSave.Text = "Save Data";
			this.cmdSave.UseVisualStyleBackColor = true;
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// cmdSaveLayers
			// 
			this.cmdSaveLayers.Location = new System.Drawing.Point(10, 130);
			this.cmdSaveLayers.Name = "cmdSaveLayers";
			this.cmdSaveLayers.Size = new System.Drawing.Size(102, 32);
			this.cmdSaveLayers.TabIndex = 9;
			this.cmdSaveLayers.Text = "Save Data (layers)";
			this.cmdSaveLayers.UseVisualStyleBackColor = true;
			this.cmdSaveLayers.Click += new System.EventHandler(this.cmdSaveLayers_Click);
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
			this.panel1.Location = new System.Drawing.Point(1021, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(324, 509);
			this.panel1.TabIndex = 10;
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
			this.panel3.Size = new System.Drawing.Size(59, 476);
			this.panel3.TabIndex = 10;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.checkBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 476);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(324, 33);
			this.panel2.TabIndex = 9;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.cmdLayers);
			this.panel4.Controls.Add(this.cmdSaveLayers);
			this.panel4.Controls.Add(this.cmdSave);
			this.panel4.Controls.Add(this.cmdLoad);
			this.panel4.Controls.Add(this.cmdShowGCode);
			this.panel4.Controls.Add(this.cmdRenameSelection);
			this.panel4.Controls.Add(this.cmdSettings);
			this.panel4.Controls.Add(this.cmdRedraw);
			this.panel4.Controls.Add(this.cmdParseData);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(901, 5);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(120, 509);
			this.panel4.TabIndex = 11;
			// 
			// cmdLayers
			// 
			this.cmdLayers.Location = new System.Drawing.Point(10, 290);
			this.cmdLayers.Name = "cmdLayers";
			this.cmdLayers.Size = new System.Drawing.Size(102, 32);
			this.cmdLayers.TabIndex = 11;
			this.cmdLayers.Text = "Layer Editor";
			this.cmdLayers.UseVisualStyleBackColor = true;
			this.cmdLayers.Click += new System.EventHandler(this.cmdLayers_Click);
			// 
			// cmdShowGCode
			// 
			this.cmdShowGCode.Location = new System.Drawing.Point(10, 252);
			this.cmdShowGCode.Name = "cmdShowGCode";
			this.cmdShowGCode.Size = new System.Drawing.Size(102, 32);
			this.cmdShowGCode.TabIndex = 2;
			this.cmdShowGCode.Text = "Preview GCode";
			this.cmdShowGCode.UseVisualStyleBackColor = true;
			this.cmdShowGCode.Click += new System.EventHandler(this.cmdShowGCode_Click);
			// 
			// cmdRenameSelection
			// 
			this.cmdRenameSelection.Location = new System.Drawing.Point(10, 214);
			this.cmdRenameSelection.Name = "cmdRenameSelection";
			this.cmdRenameSelection.Size = new System.Drawing.Size(102, 32);
			this.cmdRenameSelection.TabIndex = 2;
			this.cmdRenameSelection.Text = "Rename Selection";
			this.cmdRenameSelection.UseVisualStyleBackColor = true;
			this.cmdRenameSelection.Click += new System.EventHandler(this.cmdRenameSelection_Click);
			// 
			// cmdSettings
			// 
			this.cmdSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdSettings.Location = new System.Drawing.Point(8, 471);
			this.cmdSettings.Name = "cmdSettings";
			this.cmdSettings.Size = new System.Drawing.Size(102, 32);
			this.cmdSettings.TabIndex = 2;
			this.cmdSettings.Text = "Settings";
			this.cmdSettings.UseVisualStyleBackColor = true;
			this.cmdSettings.Click += new System.EventHandler(this.cmdSettings_Click);
			// 
			// txtFile
			// 
			this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFile.Location = new System.Drawing.Point(280, 9);
			this.txtFile.Name = "txtFile";
			this.txtFile.ReadOnly = true;
			this.txtFile.Size = new System.Drawing.Size(600, 20);
			this.txtFile.TabIndex = 10;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.radZoomSixteen);
			this.panel5.Controls.Add(this.txtFile);
			this.panel5.Controls.Add(this.radZoomEight);
			this.panel5.Controls.Add(this.radZoomFour);
			this.panel5.Controls.Add(this.radZoomTwo);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(5, 476);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(896, 38);
			this.panel5.TabIndex = 12;
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
			this.radZoomSixteen.CheckedChanged += new System.EventHandler(this.radScaleChange);
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
			this.radZoomEight.CheckedChanged += new System.EventHandler(this.radScaleChange);
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
			this.radZoomFour.CheckedChanged += new System.EventHandler(this.radScaleChange);
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
			this.radZoomTwo.CheckedChanged += new System.EventHandler(this.radScaleChange);
			// 
			// panel6
			// 
			this.panel6.AutoScroll = true;
			this.panel6.Controls.Add(this.pictureBox1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(5, 5);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(896, 471);
			this.panel6.TabIndex = 13;
			// 
			// frmPlotter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1350, 519);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Name = "frmPlotter";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Text = "JaMakinMeGCode";
			this.Load += new System.EventHandler(this.frmPlotter_Load);
			this.ResizeEnd += new System.EventHandler(this.frmPlotter_ResizeEnd);
			this.ClientSizeChanged += new System.EventHandler(this.frmPlotter_ResizeEnd);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.ResumeLayout(false);

        }
        #endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button cmdParseData;
		private System.Windows.Forms.Button cmdRedraw;
		private System.Windows.Forms.ListBox lstPlots;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button cmdShiftDown;
		private System.Windows.Forms.Button cmdShiftUp;
		private System.Windows.Forms.Button cmdToTop;
		private System.Windows.Forms.Button cmdToBottom;
		private System.Windows.Forms.Button cmdLoad;
		private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.Button cmdSaveLayers;
		private System.Windows.Forms.SaveFileDialog sfdSaveDialog;
		private System.Windows.Forms.OpenFileDialog ofdLoadDialog;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.RadioButton radZoomFour;
		private System.Windows.Forms.RadioButton radZoomTwo;
		private System.Windows.Forms.RadioButton radZoomEight;
		private System.Windows.Forms.Button cmdSettings;
		private System.Windows.Forms.RadioButton radZoomSixteen;
		private System.Windows.Forms.Button cmdRenameSelection;
		private System.Windows.Forms.Button cmdShowGCode;
		private System.Windows.Forms.Button cmdLayers;
		private System.Windows.Forms.Panel panel6;
    }
}

