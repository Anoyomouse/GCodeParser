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
	public partial class frmPlotter : Form
	{
		public frmPlotter()
		{
			InitializeComponent();
		}

		List<GCodeInstruction> parsedPlots;
		List<Plot> myPlots;
		Image renderImage = null;
		Graphics graphics = null;
		private void button1_Click(object sender, EventArgs e)
		{
			#region Code
			parsedPlots = SimpleGCodeParser.ParseText(textBox1.Text);
			StringBuilder sb = new StringBuilder();

			if (renderImage == null || renderImage.Width != pictureBox1.Width || renderImage.Height != pictureBox1.Height)
			{
				renderImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);

				if (pictureBox1.Image != null)
				{
					pictureBox1.Image.Dispose();
				}

				pictureBox1.Image = renderImage;
			}

			Graphics g = graphics = Graphics.FromImage(pictureBox1.Image);
			g.Clear(Color.FromArgb(0x20, 0x20, 0x20));

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
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			#region Code
			textBox1.Text = string.Empty;

			graphics.Clear(Color.FromArgb(0x20, 0x20, 0x20));
			pictureBox1.Image = renderImage;
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
			if (lastPlot != null)
			{
				foreach (var data in lastPlot.PlotPoints)
				{
					data.DrawSegment(graphics, pictureBox1.Height, Multiplier: 4, renderG0: checkBox1.Checked);
				}
			}

			var obj = box.SelectedItem;
			if (obj != null && obj is Plot)
			{
				Plot plot = obj as Plot;

				foreach (var data in plot.PlotPoints)
				{
					data.DrawSegment(graphics, pictureBox1.Height, p: Pens.White, Multiplier: 4, renderG0: checkBox1.Checked);
				}

				pictureBox1.Image = renderImage;

				lastPlot = plot;
			}
			else
			{
				lastPlot = null;
			}
			#endregion
		}

		private void RenderPlots()
		{
			graphics = Graphics.FromImage(renderImage);
			graphics.Clear(Color.FromArgb(0x20, 0x20, 0x20));
			foreach (Plot plotItem in myPlots)
			{
				foreach (var data in plotItem.PlotPoints)
				{
					if (plotItem == lstPlots.SelectedItem)
					{
						data.DrawSegment(graphics, pictureBox1.Height, Multiplier: 4, renderG0: checkBox1.Checked, p: Pens.White);
					}
					else
					{
						data.DrawSegment(graphics, pictureBox1.Height, Multiplier: 4, renderG0: checkBox1.Checked);
					}
				}
			}

			pictureBox1.Image = renderImage;
		}
	}
}
