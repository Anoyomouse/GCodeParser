using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCodePlotter
{
	public partial class frmPlotter : Form
	{
		public frmPlotter()
		{
			InitializeComponent();
		}

		private void frmPlotter_Load(object sender, EventArgs e)
		{
			#region Code
			if (renderImage == null ||
				renderImage.Width != pictureBox1.Width ||
				renderImage.Height != pictureBox1.Height)
			{
				renderImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);

				if (pictureBox1.Image != null)
				{
					pictureBox1.Image.Dispose();
				}

				pictureBox1.Image = renderImage;
			}

			var lastFile = QuickSettings.Get["LastOpenedFile"];
			if (!string.IsNullOrWhiteSpace(lastFile))
			{
				// Load data here!
				FileInfo fil = new FileInfo(lastFile);
				if (fil.Exists)
				{
					txtFile.Text = fil.Name;
					txtFile.Tag = fil.FullName;
					Application.DoEvents();
					button1.Enabled = true;
					button1.PerformClick();
				}
			}
			#endregion
		}

		//List<GCodeInstruction> parsedPlots;
		List<Plot> myPlots;
		Image renderImage = null;
		private void button1_Click(object sender, EventArgs e)
		{
			#region Code
			FileInfo file = new FileInfo(txtFile.Tag.ToString());
			StreamReader tr = file.OpenText();
			string data = tr.ReadToEnd();
			tr.Close();

			ParseText(data);
			#endregion
		}

		public void ParseText(string text)
		{
			#region Code
			var parsedPlots = SimpleGCodeParser.ParseText(text);
			StringBuilder sb = new StringBuilder();

			lstPlots.Items.Clear();

			PointF currentPoint = new PointF(0, 0);
			currentPoint.X = 0;
			currentPoint.Y = 0;

			myPlots = new List<Plot>();
			Plot currentPlot = new Plot();
			foreach (var line in parsedPlots)
			{
				sb.Append(line).AppendLine();
				if (line.IsOnlyComment)
				{
					if (line.Comment.StartsWith("Start cutting path id:"))
					{
						if (currentPlot.PlotPoints.Count > 0)
						{
							var point = currentPlot.PlotPoints[currentPlot.PlotPoints.Count - 1];
							currentPlot.endPoint = new PointF(point.X2, point.Y2);
							myPlots.Add(currentPlot);
							// New plot!
							currentPlot = new Plot();
							currentPlot.startSet = false;
						}
						currentPlot.Name = line.Comment.Substring(23);
					}

					if (line.Comment.StartsWith("End cutting path id:"))
					{
						if (currentPlot.PlotPoints.Count > 0)
						{
							var point = currentPlot.PlotPoints[currentPlot.PlotPoints.Count - 1];
							currentPlot.endPoint = new PointF(point.X2, point.Y2);
							myPlots.Add(currentPlot);
							// New plot!
							currentPlot = new Plot();
						}
					}
				}
				else if (line.CanRender())
				{
					currentPlot.PlotPoints.AddRange(line.RenderCode(ref currentPoint));
					currentPlot.GCodeInstructions.Add(line);

					if (line.CommandEnum == CommandList.RapidMove && (line.X != null || line.Y != null))
					{
						var point = currentPlot.PlotPoints[0];
						currentPlot.startPoint = new PointF(point.X2, point.Y2);
					}
				}
			}

			if (currentPlot.PlotPoints.Count > 0)
			{
				var point = currentPlot.PlotPoints[currentPlot.PlotPoints.Count - 1];
				currentPlot.endPoint = new PointF(point.X2, point.Y2);
				myPlots.Add(currentPlot);
			}

			myPlots.ForEach(x => lstPlots.Items.Add(x));

			RenderPlots();
			#endregion
		}

		private void CalculateGCodePlot()
		{
			#region Code
			PointF currentPoint = new PointF(0, 0);
			currentPoint.X = 0;
			currentPoint.Y = 0;

			foreach (var plot in lstPlots.Items.Cast<Plot>())
			{
				plot.PlotPoints.Clear();
				foreach (var line in plot.GCodeInstructions)
				{
					plot.PlotPoints.AddRange(line.RenderCode(ref currentPoint));
				}
			}
			#endregion
		}

		private void button2_Click(object sender, EventArgs e)
		{
			#region Code
			RenderPlots();
			#endregion
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			#region Code
			if (renderImage == null)
			{
				return;
			}

			RenderPlots();
			#endregion
		}

		private void cmdShiftDown_Click(object sender, EventArgs e)
		{
			#region Code
			var objs = lstPlots.SelectedItems.Cast<object>().ToList();
			var idx = lstPlots.SelectedIndex;
			if (idx >= lstPlots.Items.Count - objs.Count)
			{
				idx = lstPlots.Items.Count - objs.Count;
			}

			foreach (Plot i in objs)
			{
				myPlots.Remove(i);
				lstPlots.Items.Remove(i);
			}

			for(int i = 0; i < objs.Count; i++)
			{
				if ((idx + i) >= lstPlots.Items.Count)
				{
					lstPlots.Items.Add(objs[i]);
					myPlots.Add((Plot)objs[i]);
				}
				else
				{
					lstPlots.Items.Insert(idx + i + 1, objs[i]);
					myPlots.Insert(idx + i + 1, (Plot)objs[i]);
				}

				lstPlots.SelectedItems.Add(objs[i]);
			}

			CalculateGCodePlot();
			RenderPlots();
			#endregion
		}

		private void cmdToBottom_Click(object sender, EventArgs e)
		{
			#region Code
			var objs = lstPlots.SelectedItems.Cast<object>().ToList();
			var idx = lstPlots.SelectedIndex;
			foreach (Plot i in objs)
			{
				lstPlots.Items.Remove(i);
				myPlots.Remove(i);
			}

			for (int i = 0; i < objs.Count; i++)
			{
				lstPlots.Items.Add(objs[i]);
				myPlots.Add((Plot)objs[i]);
				lstPlots.SelectedItems.Add(objs[i]);
			}

			CalculateGCodePlot();
			RenderPlots();
			#endregion
		}

		private void cmdShiftUp_Click(object sender, EventArgs e)
		{
			#region Code
			var objs = lstPlots.SelectedItems.Cast<object>().ToList();
			var idx = lstPlots.SelectedIndex;
			if (idx < 1)
			{
				idx = 1;
			}

			foreach (Plot i in objs)
			{
				lstPlots.Items.Remove(i);
				myPlots.Remove(i);
			}

			for (int i = 0; i < objs.Count; i++)
			{
				lstPlots.Items.Insert(idx + i - 1, objs[i]);
				myPlots.Insert(idx + i - 1, (Plot)objs[i]);
				lstPlots.SelectedItems.Add(objs[i]);
			}

			CalculateGCodePlot();
			RenderPlots();
			#endregion
		}

		private void cmdToTop_Click(object sender, EventArgs e)
		{
			#region Code
			var objs = lstPlots.SelectedItems.Cast<object>().ToList();
			var idx = lstPlots.SelectedIndex;
			foreach (Plot i in objs)
			{
				lstPlots.Items.Remove(i);
				myPlots.Remove(i);
			}

			for (int i = 0; i < objs.Count; i++)
			{
				lstPlots.Items.Insert(i, objs[i]);
				myPlots.Insert(i, (Plot)objs[i]);
				lstPlots.SelectedItems.Add(objs[i]);
			}

			CalculateGCodePlot();
			RenderPlots();
			#endregion
		}

		private void lstPlots_SelectedIndexChanged(object sender, EventArgs e)
		{
			#region Code
			SelectPlot(lstPlots);
			#endregion
		}

		//Plot lastPlot = null;
		private void SelectPlot(ListBox box)
		{
			#region Code
			RenderPlots();

			pictureBox1.Refresh();
			#endregion
		}

		private void RenderPlots()
		{
			#region Code
			var graphics = Graphics.FromImage(renderImage);
			graphics.Clear(ColorHelper.GetColor(PenColorList.Background));

			var multiplier = 4f;
			if (radZoomTwo.Checked) multiplier = 2;
			else if (radZoomFour.Checked) multiplier = 4;
			else if (radZoomEight.Checked) multiplier = 8;
			else if (radZoomSixteen.Checked) multiplier = 16;

			var scale = (10 * multiplier);

			Pen gridPen = ColorHelper.GetPen(PenColorList.GridLines);
			for (var x = 1; x < pictureBox1.Width / scale; x++)
			{
				for (var y = 1; y < pictureBox1.Height / scale; y++)
				{
					graphics.DrawLine(gridPen, x * scale, 0, x * scale, pictureBox1.Height);
					graphics.DrawLine(gridPen, 0, pictureBox1.Height - (y * scale), pictureBox1.Width, pictureBox1.Height - (y * scale));
				}
			}

			if (myPlots != null && myPlots.Count > 0)
			{
				foreach (Plot plotItem in myPlots)
				{
					foreach (var data in plotItem.PlotPoints)
					{
						if (lstPlots.SelectedItems.Contains(plotItem))
						{
							data.DrawSegment(graphics, pictureBox1.Height, Multiplier: multiplier, renderG0: checkBox1.Checked, highlight: true);
						}
						else
						{
							data.DrawSegment(graphics, pictureBox1.Height, Multiplier: multiplier, renderG0: checkBox1.Checked);
						}
					}
				}
			}

			pictureBox1.Refresh();
			#endregion
		}

		private void cmdLoad_Click(object sender, EventArgs e)
		{
			#region Code
			var result = ofdLoadDialog.ShowDialog();
			if (result == System.Windows.Forms.DialogResult.OK)
			{
				var file = new FileInfo(ofdLoadDialog.FileName);
				if (!file.Exists)
				{
					MessageBox.Show("Selected file does not exist, please select an existing file!");
					return;
				}

				QuickSettings.Get["LastOpenedFile"] = file.FullName;

				StreamReader tr = file.OpenText();
				string data = tr.ReadToEnd();
				tr.Close();

				ParseText(data);
			}
			#endregion
		}

		private void txtFile_TextChanged(object sender, EventArgs e)
		{

		}

		private void frmPlotter_ResizeEnd(object sender, EventArgs e)
		{
			#region Code
			if (renderImage == null ||
				renderImage.Width != pictureBox1.Width ||
				renderImage.Height != pictureBox1.Height)
			{
				renderImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);

				if (pictureBox1.Image != null)
				{
					pictureBox1.Image.Dispose();
				}

				pictureBox1.Image = renderImage;
			}

			RenderPlots();
			#endregion
		}

		private void radScaleChange(object sender, EventArgs e)
		{
			RenderPlots();
		}

		private void cmdSettings_Click(object sender, EventArgs e)
		{
			SettingsForm frm = new SettingsForm();
			frm.FormClosed += (s, evt) => this.RenderPlots();
			frm.StartPosition = FormStartPosition.CenterParent;
			frm.ValueChanged += (s, evt) => this.RenderPlots();
			frm.Show(this);
		}

		private void cmdRenameSelection_Click(object sender, EventArgs e)
		{
			#region Code
			if (lstPlots.SelectedItems.Count == 0)
			{
				return;
			}

			frmRenamePlots frm = new frmRenamePlots();
			frm.StartPosition = FormStartPosition.CenterParent;

			List<Plot> items = new List<Plot>(lstPlots.SelectedItems.Cast<Plot>());
			foreach (var p in items)
			{
				frm.AddPlot(p.ToString());
			}

			var res = frm.ShowDialog(this);
			if (res == System.Windows.Forms.DialogResult.OK)
			{
				int counter = 1;
				foreach (var p in items)
				{
					var idx = lstPlots.Items.IndexOf(p);
					var plot = myPlots[idx];

					plot.Name = string.Format("{0}{1}", frm.NewPlotName, counter);

					lstPlots.Items.Remove(plot);
					lstPlots.Items.Insert(idx, plot);
					lstPlots.SelectedItems.Add(plot);

					counter++;
				}

				lstPlots.Refresh();
			}
			#endregion
		}
	}
}
