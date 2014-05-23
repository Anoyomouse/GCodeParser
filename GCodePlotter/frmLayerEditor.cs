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
	public partial class frmLayerEditor : Form
	{
		public frmLayerEditor()
		{
			InitializeComponent();
		}

		private void frmLayerEditor_Load(object sender, EventArgs e)
		{
			var data = QuickSettings.Get["ZDepths"];
			if (string.IsNullOrEmpty(data))
			{
				data = "-0.1,-0.15,-0.2";
			}

			string [] bits = null;
			if (data.Contains(','))
				bits = data.Split(',');
			else
				bits = new string[] { data};

			StringBuilder sb = new StringBuilder();
			foreach(var line in bits)
			{
				float f;
				if (float.TryParse(line, out f))
				{
					if (sb.Length > 0)
						sb.AppendLine();
					sb.Append(f.ToString());
				}
			}

			textBox1.Text = sb.ToString();
		}

		public void SaveData()
		{
			var data = textBox1.Text;
			string [] bits = null;

			data = data.Replace("\r\n", "\n");

			if (data.Contains('\n'))
				bits = data.Split('\n');
			else
				bits = new string[] { data.Trim('\r','\n',' ') };

			StringBuilder sb = new StringBuilder();
			foreach(var line in bits)
			{
				float f;
				if (float.TryParse(line, out f))
				{
					if (sb.Length > 0)
						sb.Append(',');
					sb.Append(f.ToString());
				}
			}

			QuickSettings.Get["ZDepths"] = sb.ToString();
		}

		private void cmdOk_Click(object sender, EventArgs e)
		{
			SaveData();
		}
	}
}
