/**
 * Copyright (c) David-John Miller AKA Anoyomouse 2014
 *
 * See LICENCE in the project directory for licence information
 **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlSuite
{
	public partial class ColorPickerBox : UserControl
	{
		public ColorPickerBox()
		{
			InitializeComponent();
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			#region Code
			if (this.Height != txtHex.Height)
			{
				this.Height = txtHex.Height;
				cmdSelect.Height = txtHex.Height;
			}
			base.OnSizeChanged(e);
			#endregion
		}

		Color _my_color = Color.White;

		private void cmdSelect_Click(object sender, EventArgs e)
		{
			#region Code
			ColorDialog cd = new ColorDialog();
			cd.AnyColor = true;
			cd.AllowFullOpen = true;
			cd.FullOpen = true;
			cd.SolidColorOnly = false;
			cd.Color = _my_color;
			var res = cd.ShowDialog(this);
			if (res != DialogResult.OK)
				return;

			_my_color = cd.Color;
			txtHex.BackColor = _my_color;
			#endregion
		}

		public Color Value
		{
			get { return this.SelectedColor; }
			set { this.SelectedColor = value; }
		}

		public event EventHandler ValueChanged;

		public Color SelectedColor
		{
			get
			{
				return _my_color;
			}
			set
			{
				_my_color = value;
				txtHex.BackColor = value;
				if (this.ValueChanged != null)
				{
					this.ValueChanged(this, EventArgs.Empty);
				}
			}
		}

		private void ColorPickerBox_Load(object sender, EventArgs e)
		{
			#region Code
			if (_my_color == System.Drawing.Color.Empty)
				_my_color = Color.White;

			txtHex.BackColor = _my_color;
			#endregion
		}
	}
}
