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

		private Plot _plot;

		public Plot GCodePlot
		{
			set
			{
				_plot = value;
				lstPlots.Items.Clear();
				foreach (var line in value.GCodeInstructions)
				{
					lstPlots.Items.Add(line);
				}
				txtFile.Text = _plot.Name;

				RedrawPlot();
			}
			get
			{
				return _plot;
			}
		}

		Image renderImage = null;
		public void RedrawPlot()
		{
			var multiplier = 4f;
			if (radZoomTwo.Checked) multiplier = 2;
			else if (radZoomFour.Checked) multiplier = 4;
			else if (radZoomEight.Checked) multiplier = 8;
			else if (radZoomSixteen.Checked) multiplier = 16;

			var scale = (10 * multiplier);

			PointF first = new PointF(_plot.minX, _plot.minY);
			_plot.Replot(ref first);

			float absMaxX = 0f, absMaxY = 0f;

			absMaxX = _plot.maxX - _plot.minX;
			absMaxY = _plot.maxY - _plot.minY;

			absMaxX *= scale;
			absMaxY *= scale;

			var intAbsMaxX = (int)(absMaxX + 1) / 10 + 40;
			var intAbsMaxY = (int)(absMaxY + 1) / 10 + 40;

			if (renderImage == null || intAbsMaxX != renderImage.Width || intAbsMaxY != renderImage.Height)
			{
				if (renderImage != null)
				{
					renderImage.Dispose();
				}

				renderImage = new Bitmap(intAbsMaxX, intAbsMaxY);
				pictureBox1.Width = intAbsMaxX;
				pictureBox1.Height = intAbsMaxY;
				pictureBox1.Image = renderImage;
			}

			var graphics = Graphics.FromImage(renderImage);
			graphics.Clear(ColorHelper.GetColor(PenColorList.Background));

			Pen gridPen = ColorHelper.GetPen(PenColorList.GridLines);
			for (var x = 1; x < pictureBox1.Width / scale; x++)
			{
				for (var y = 1; y < pictureBox1.Height / scale; y++)
				{
					graphics.DrawLine(gridPen, x * scale, 0, x * scale, pictureBox1.Height);
					graphics.DrawLine(gridPen, 0, pictureBox1.Height - (y * scale), pictureBox1.Width, pictureBox1.Height - (y * scale));
				}
			}

			foreach (var codes in _plot.GCodeInstructions)
			{
				var bHighlight = (lstPlots.SelectedItem as GCodeInstruction == codes);

				foreach (var data in codes.CachedLinePoints)
				{
					data.DrawSegment(graphics, pictureBox1.Height, Multiplier: multiplier, renderG0: true, left: (int)Math.Truncate(_plot.minX), top: (int)Math.Truncate(_plot.minY), highlight: bHighlight);
				}
			}

			pictureBox1.Refresh();
		}

		private void chkChanged(object sender, EventArgs e)
		{
			RedrawPlot();
		}

		private void lstPlots_SelectedValueChanged(object sender, EventArgs e)
		{
			RedrawPlot();
		}
	}
}
