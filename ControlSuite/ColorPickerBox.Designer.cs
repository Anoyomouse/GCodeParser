namespace ControlSuite
{
	partial class ColorPickerBox
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.txtHex = new System.Windows.Forms.TextBox();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHex
            // 
            this.txtHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHex.Location = new System.Drawing.Point(0, 0);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(100, 20);
            this.txtHex.TabIndex = 0;
            this.txtHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdSelect
            // 
            this.cmdSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdSelect.Location = new System.Drawing.Point(100, 0);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(20, 23);
            this.cmdSelect.TabIndex = 1;
            this.cmdSelect.UseVisualStyleBackColor = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // ColorPickerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.cmdSelect);
            this.Name = "ColorPickerBox";
            this.Size = new System.Drawing.Size(120, 23);
            this.Load += new System.EventHandler(this.ColorPickerBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtHex;
		private System.Windows.Forms.Button cmdSelect;
	}
}
