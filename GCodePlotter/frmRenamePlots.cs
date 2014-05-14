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
	public partial class frmRenamePlots : Form
	{
		public frmRenamePlots()
		{
			InitializeComponent();
		}

		private void frmRenamePlots_Load(object sender, EventArgs e)
		{

		}

		public string NewPlotName { get { return textBox1.Text; } }

		public void AddPlot(string name)
		{
			listBox1.Items.Add(name);
		}
	}
}
