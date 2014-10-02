/**
 * Copyright (c) David-John Miller AKA Anoyomouse 2014
 *
 * See LICENCE in the project directory for licence information
 **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCodePlotter
{
	public partial class frmGCodePreview : Form
	{
		public frmGCodePreview()
		{
			InitializeComponent();
		}

		private void frmGCodePreview_Load(object sender, EventArgs e)
		{

		}

		public string GCodeText
		{
			set
			{
				textBox1.Text = value;
			}
		}
	}
}
