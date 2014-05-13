using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCodePlotter
{
	public static class SimpleGCodeParser
	{
		public static List<GCodeInstruction> ParseText(string text)
		{
			#region Code
			text = text.Replace("\r\n", "\n");
			text = text.Replace("\r", "\n");

			string[] lines = text.Split('\n');

			var parsed = new List<GCodeInstruction>();

			foreach (string s in lines)
			{
				parsed.Add(ParseLine(s));
			}

			return parsed;
			#endregion
		}

		private static GCodeInstruction ParseLine(string line)
		{
			#region Code
			line = line.Trim(' ', '\t', '\n');
			return new GCodeInstruction(line);
			#endregion
		}
	}

	public enum CommandList
	{
		RapidMove = 0,
		NormalMove = 1,
		CWArc = 2,
		CCWArc = 3,
		Dwell = 4,
		Other = 99
	}

	public enum PenColorList
	{
		RapidMove,
		NormalMove,
		CWArc,
		CCWArc,
		RapidMoveHilight,
		LineHighlight,
		Background,
		GridLines
	}

	public class GCodeInstruction
	{
		//public const float Multiplier = 1;
		public const float CurveSection = 1;

		public static bool AbsoluteMode = true;

		public static Pen GetColorFor(PenColorList list)
		{
			#region Code
			if (list == PenColorList.RapidMove) return Pens.Red;
			if (list == PenColorList.NormalMove) return Pens.DodgerBlue;
			if (list == PenColorList.CWArc) return Pens.Lime;
			if (list == PenColorList.CCWArc) return Pens.Yellow;
			if (list == PenColorList.RapidMoveHilight) return Pens.Salmon;
			if (list == PenColorList.LineHighlight) return Pens.White;
			if (list == PenColorList.Background) return new Pen(Color.FromArgb(0x20, 0x20, 0x20), 1);
			if (list == PenColorList.GridLines) return Pens.DarkGray;
			return Pens.White;
			#endregion
		}

		public GCodeInstruction(string line)
		{
			#region Code
			if (line.StartsWith("(") && line.EndsWith(")"))
			{
				this.Comment = line.Trim('(', ')');
				IsOnlyComment = true;
				return;
			}

			IsOnlyComment = false;
			if (line.Contains('('))
			{
				var fst = line.IndexOf('(');
				var nxt = line.IndexOf(')', fst);
				this.Comment = line.Substring(fst + 1, nxt - fst - 1);

				if (nxt + 1 < line.Length)
				{
					line = string.Format("{0} {1}", line.Substring(0, fst - 1), line.Substring(nxt + 1));
				}
				else
				{
					line = line.Substring(0, fst - 1);
				}

				line = line.Trim(' ', '\t', '\n');
			}

			if (!line.Contains(' '))
			{
				this.Command = line;
			}

			string[] bits = line.Split(' ');
			this.Command = bits[0];
			for (int i = 1; i < bits.Length; i++)
			{
				char axis = bits[i][0];
				float? dist = null;

				if (bits[i].Length == 1) // Only Axis, so dist is in next field!
				{
					i++;
					if (i >= bits.Length)
					{
						throw new ParsingException(string.Format("No distance specified for {0}", axis));
					}

					dist = float.Parse(bits[i]);
				}
				else
				{
					dist = float.Parse(bits[i].Substring(1));
				}

				if (!dist.HasValue) throw new ParsingException(string.Format("No distance specified for {0}", axis));

				if (dist.HasValue) { dist = dist.Value; } // * Multiplier

				switch (char.ToUpper(axis))
				{
					case 'X': this.X = dist; break;
					case 'Y': this.Y = dist; break;
					case 'Z': this.Z = dist; break;
					case 'F': this.F = dist; break;
					case 'I': this.I = dist; break;
					case 'J': this.J = dist; break;
				}
			}
			#endregion
		}

		public string Comment { get; set; }
		public string Command { get; set; }
		public float? X { get; set; }
		public float? Y { get; set; }
		public float? Z { get; set; }
		public float? F { get; set; }
		public float? I { get; set; }
		public float? J { get; set; }

		public string CommandType
		{
			get
			{
				#region Code
				switch (Command)
				{
					case "G0":
					case "G00": return "Rapid Move";
					case "G1":
					case "G01": return "Coordinated motion";
					case "G2":
					case "G02": return "Clockwise arc motion";
					case "G3":
					case "G03": return "Counter clockwise arc motion";
					case "G90": return "Absolute Mode";
					case "G91": return "Relative Mode";
					case "G21": return "G21";
				}
				return "Unknown " + Command;
				#endregion
			}
		}

		public CommandList CommandEnum
		{
			get
			{
				#region Code
				switch (Command)
				{
					case "G0":
					case "G00": return CommandList.RapidMove;
					case "G1":
					case "G01": return CommandList.NormalMove;
					case "G2":
					case "G02": return CommandList.CWArc;
					case "G3":
					case "G03": return CommandList.CCWArc;
					case "G4":
					case "G04": return CommandList.Dwell;
				}
				return CommandList.Other;
				#endregion
			}
		}

		public override string ToString()
		{
			#region Code
			if (string.IsNullOrWhiteSpace(Command))
			{
				return string.Format("({0})", Comment);
			}

			StringBuilder sb = new StringBuilder();
			sb.Append(this.Command);

			if (X.HasValue) sb.AppendFormat(" X {0:F4}", this.X);
			if (Y.HasValue) sb.AppendFormat(" Y {0:F4}", this.Y);
			if (Z.HasValue) sb.AppendFormat(" Z {0:F4}", this.Z);
			if (I.HasValue) sb.AppendFormat(" I {0:F4}", this.I);
			if (J.HasValue) sb.AppendFormat(" J {0:F4}", this.J);
			if (F.HasValue) sb.AppendFormat(" F {0:F4}", this.F);
			if (!string.IsNullOrWhiteSpace(Comment))
				sb.AppendFormat(" ({0})", Comment);

			return sb.ToString();
			#endregion
		}

		internal bool IsOnlyComment { get; private set; }

		internal bool CanRender()
		{
			#region Code
			if (CommandEnum == CommandList.NormalMove ||
				CommandEnum == CommandList.RapidMove ||
				CommandEnum == CommandList.CWArc ||
				CommandEnum == CommandList.CCWArc)
				return true;
			return false;
			#endregion
		}

		internal List<LinePoints> RenderCode(ref PointF currentPoint)
		{
			#region Code
			if (CommandEnum == CommandList.Other)
			{
				if (Command == "G90") { AbsoluteMode = true; }
				if (Command == "G91") { AbsoluteMode = false; }
				return null;
			}
			if (CommandEnum == CommandList.Dwell)
				return null;

			var pos = new PointF(currentPoint.X, currentPoint.Y);
			if (AbsoluteMode)
			{
				if (X.HasValue)
					pos.X = X.Value;
				if (Y.HasValue)
					pos.Y = Y.Value;
				//if (Z.HasValue)
				//	pos.Z = (int)(Z.Value * Multiplier);
			}
			// relative specifies a delta
			else
			{
				if (X.HasValue)
					pos.X += X.Value;
				if (Y.HasValue)
					pos.Y += Y.Value;
				//if (Z.HasValue)
				//	pos.Z += (int)(Z.Value * Multiplier);
			}

			if (CommandEnum == CommandList.RapidMove || CommandEnum == CommandList.NormalMove)
			{
				var line = new LinePoints(currentPoint, pos, GetColorFor(CommandEnum == CommandList.RapidMove ? PenColorList.RapidMove : PenColorList.NormalMove));
				currentPoint.X = pos.X;
				currentPoint.Y = pos.Y;
				return new List<LinePoints>() { line };
			}

			if (CommandEnum == CommandList.CWArc || CommandEnum == CommandList.CCWArc)
			{
				PointF center = new PointF(0f, 0f);
				PointF current = new PointF(currentPoint.X, currentPoint.Y);
				center.X = current.X + this.I ?? 0;
				center.Y = current.Y + this.J ?? 0;

				return RenderArc(center, pos, (CommandEnum == CommandList.CWArc), ref currentPoint);
			}

			return null;
			#endregion
		}

		private List<LinePoints> RenderArc(PointF center, PointF endpoint, bool clockwise, ref PointF currentPosition)
		{
			#region Code
			// angle variables.
			double angleA;
			double angleB;
			double angle;
			double radius;
			double length;

			// delta variables.
			double aX;
			double aY;
			double bX;
			double bY;

			// figure out our deltas
			PointF current = new PointF(currentPosition.X, currentPosition.Y);
			aX = current.X - center.X;
			aY = current.Y - center.Y;
			bX = endpoint.X - center.X;
			bY = endpoint.Y - center.Y;

			// Clockwise
			if (clockwise)
			{
				angleA = Math.Atan2(bY, bX);
				angleB = Math.Atan2(aY, aX);
			}
			// Counterclockwise
			else
			{
				angleA = Math.Atan2(aY, aX);
				angleB = Math.Atan2(bY, bX);
			}

			// Make sure angleB is always greater than angleA
			// and if not add 2PI so that it is (this also takes
			// care of the special case of angleA == angleB,
			// ie we want a complete circle)
			if (angleB <= angleA)
				angleB += 2 * Math.PI;
			angle = angleB - angleA;
			// calculate a couple useful things.
			radius = Math.Sqrt(aX * aX + aY * aY);
			length = radius * angle;

			// for doing the actual move.
			int steps;
			int s;
			int step;

			// Maximum of either 2.4 times the angle in radians
			// or the length of the curve divided by the curve section constant
			steps = (int)Math.Ceiling(Math.Max(angle * 2.4, length / CurveSection));

			// this is the real draw action.
			PointF newPoint = new PointF(current.X, current.Y);
			PointF lastPoint = new PointF(current.X, current.Y);
			List<LinePoints> output = new List<LinePoints>();
			Pen p = GetColorFor(clockwise ? PenColorList.CWArc : PenColorList.CCWArc);
			for (s = 1; s <= steps; s++)
			{
				// Forwards for CCW, backwards for CW
				if (!clockwise)
					step = s;
				else
					step = steps - s;

				// calculate our waypoint.
				newPoint.X = (float)((center.X + radius * Math.Cos(angleA + angle * ((double)step / steps))));
				newPoint.Y = (float)((center.Y + radius * Math.Sin(angleA + angle * ((double)step / steps))));
				//newPoint.setZ(arcStartZ + (endpoint.z() - arcStartZ) * s / steps);

				output.Add(new LinePoints(currentPosition, newPoint, p));
				// start the move
				currentPosition.X = newPoint.X;
				currentPosition.Y = newPoint.Y;
			}
			return output;
			#endregion
		}
	}

	public struct LinePoints
	{
		public LinePoints(PointF start, PointF end, Pen pen)
			: this()
		{
			#region Code
			X1 = start.X;
			Y1 = start.Y;
			X2 = end.X;
			Y2 = end.Y;
			Pen = pen;
			#endregion
		}

		public LinePoints(float x1, float y1, float x2, float y2, Pen pen)
			: this()
		{
			#region Code
			X1 = x1;
			Y1 = y1;
			X2 = x2;
			Y2 = y2;
			Pen = pen;
			#endregion
		}

		public float X1 { get; set; }
		public float Y1 { get; set; }
		public float X2 { get; set; }
		public float Y2 { get; set; }
		public Pen Pen { get; set; }

		public void DrawSegment(Graphics g, int height, Pen p = null, float Multiplier = 1, bool renderG0 = true)
		{
			#region Code
			if (Pen == GCodeInstruction.GetColorFor(PenColorList.RapidMove) && !renderG0)
			{
				return;
			}
			else if (Pen == GCodeInstruction.GetColorFor(PenColorList.RapidMove) && p != null)
			{
				g.DrawLine(GCodeInstruction.GetColorFor(PenColorList.RapidMoveHilight), X1 * Multiplier, height - (Y1 * Multiplier), X2 * Multiplier, height - (Y2 * Multiplier));
				return;
			}

			if (p != null)
			{
				g.DrawLine(p, X1 * Multiplier, height - (Y1 * Multiplier), X2 * Multiplier, height - (Y2 * Multiplier));
			}
			else
			{
				g.DrawLine(Pen, X1 * Multiplier, height - (Y1 * Multiplier), X2 * Multiplier, height - (Y2 * Multiplier));
			}
			#endregion
		}
	}

	public class Plot
	{
		public string Name { get; set; }
		private List<LinePoints> plotPoints = new List<LinePoints>();
		public List<LinePoints> PlotPoints { get { return plotPoints; } }

		private List<GCodeInstruction> gcodeInstructions = new List<GCodeInstruction>();
		public List<GCodeInstruction> GCodeInstructions { get { return gcodeInstructions; } }

		public PointF startPoint { get; set; }
		public PointF endPoint { get; set; }

		public bool startSet { get; set; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Plot: {0} with {1} lines", Name, PlotPoints != null ? PlotPoints.Count : 0);
			if (startPoint == endPoint)
			{
				sb.Append(" loop");
			}
			return sb.ToString();
		}
	}

	public class ParsingException : Exception
	{
		public ParsingException(string message)
			: base(message)
		{

		}

		public ParsingException(string message, Exception inner)
			: base(message, inner)
		{

		}
	}
}
