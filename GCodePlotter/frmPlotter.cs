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
					button1.PerformClick();
				}
			}
			#endregion
		}

		List<GCodeInstruction> parsedPlots;
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
			parsedPlots = SimpleGCodeParser.ParseText(text);
			StringBuilder sb = new StringBuilder();

			myPlots = new List<Plot>();

			PointF currentPoint = new PointF(0, 0);
			currentPoint.X = 0;
			currentPoint.Y = 0;

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

			foreach (var plot in myPlots)
			{
				lstPlots.Items.Add(plot);
			}

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
			Graphics g = Graphics.FromImage(renderImage);
			g.Clear(Color.FromArgb(0x20, 0x20, 0x20));

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
			if (lstPlots.SelectedIndex == (lstPlots.Items.Count - 1) || lstPlots.SelectedItem == null)
			{
				return;
			}

			var obj = lstPlots.SelectedItem;
			var idx = lstPlots.SelectedIndex;
			lstPlots.Items.Remove(obj);
			lstPlots.Items.Insert(idx + 1, obj);
			lstPlots.SelectedItem = obj;

			CalculateGCodePlot();
			RenderPlots();
			#endregion
		}

		private void cmdToBottom_Click(object sender, EventArgs e)
		{
			#region Code
			if (lstPlots.SelectedIndex == (lstPlots.Items.Count - 1) || lstPlots.SelectedItem == null)
			{
				return;
			}

			var obj = lstPlots.SelectedItem;
			var idx = lstPlots.SelectedIndex;
			lstPlots.Items.Remove(obj);
			lstPlots.Items.Add(obj);
			lstPlots.SelectedItem = obj;

			CalculateGCodePlot();
			RenderPlots();
			#endregion
		}

		private void cmdShiftUp_Click(object sender, EventArgs e)
		{
			#region Code
			if (lstPlots.SelectedIndex == 0 || lstPlots.SelectedItem == null)
			{
				return;
			}

			var obj = lstPlots.SelectedItem;
			var idx = lstPlots.SelectedIndex;
			lstPlots.Items.Remove(obj);
			lstPlots.Items.Insert(idx - 1, obj);
			lstPlots.SelectedItem = obj;

			CalculateGCodePlot();
			RenderPlots();
			#endregion
		}

		private void cmdToTop_Click(object sender, EventArgs e)
		{
			#region Code
			if (lstPlots.SelectedIndex == 0 || lstPlots.SelectedItem == null)
			{
				return;
			}

			var obj = lstPlots.SelectedItem;
			var idx = lstPlots.SelectedIndex;
			lstPlots.Items.Remove(obj);
			lstPlots.Items.Insert(0, obj);
			lstPlots.SelectedItem = obj;

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

		Plot lastPlot = null;
		private void SelectPlot(ListBox box)
		{
			#region Code
			Graphics g = Graphics.FromImage(renderImage);

			if (lastPlot != null)
			{
				foreach (var data in lastPlot.PlotPoints)
				{
					data.DrawSegment(g, pictureBox1.Height, Multiplier: 4, renderG0: checkBox1.Checked);
				}
			}

			var obj = box.SelectedItem;
			if (obj != null && obj is Plot)
			{
				Plot plot = obj as Plot;

				foreach (var data in plot.PlotPoints)
				{
					data.DrawSegment(g, pictureBox1.Height, p: Pens.White, Multiplier: 4, renderG0: checkBox1.Checked);
				}

				lastPlot = plot;
			}
			else
			{
				lastPlot = null;
			}

			pictureBox1.Refresh();
			#endregion
		}

		private void RenderPlots()
		{
			#region Code
			var graphics = Graphics.FromImage(renderImage);
			graphics.Clear(Color.FromArgb(0x20, 0x20, 0x20));

			var multiplier = 4f;
			if (radZoomOne.Checked) multiplier = 1;
			else if (radZoomTwo.Checked) multiplier = 2;
			else if (radZoomHalf.Checked) multiplier = 0.5f;
			else if (radZoomFour.Checked) multiplier = 4;
			else if (radZoomEight.Checked) multiplier = 8;

			var scale = (10 * multiplier);

			for (var x = 1; x < pictureBox1.Width / scale; x++)
			{
				for (var y = 1; y < pictureBox1.Height / scale; y++)
				{
					graphics.DrawLine(Pens.Gray, x * scale, 0, x* scale, pictureBox1.Height);
					graphics.DrawLine(Pens.Gray, 0, pictureBox1.Height - (y * scale), pictureBox1.Width, pictureBox1.Height - (y * scale));
				}
			}

			foreach (Plot plotItem in myPlots)
			{
				foreach (var data in plotItem.PlotPoints)
				{
					if (plotItem == lstPlots.SelectedItem)
					{
						data.DrawSegment(graphics, pictureBox1.Height, Multiplier: multiplier, renderG0: checkBox1.Checked, p: Pens.White);
					}
					else
					{
						data.DrawSegment(graphics, pictureBox1.Height, Multiplier: multiplier, renderG0: checkBox1.Checked);
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
	}
}
