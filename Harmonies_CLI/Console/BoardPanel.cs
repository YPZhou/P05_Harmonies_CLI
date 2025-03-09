using static Harmonies_CLI.Constants;

namespace Harmonies_CLI
{
	class BoardPanel : IPanel
	{
		public BoardPanel(Board board)
		{
			this.board = board;
		}

		Board board;

		void IPanel.Draw()
		{
			DrawBoard();
			DrawLegend();
			DrawCursorDetails();
		}

		void IPanel.ProcessKey(ConsoleKey key)
		{
			if (key == ConsoleKey.LeftArrow)
			{
				board.MoveCursor(-1, -1);
			}
			else if (key == ConsoleKey.RightArrow)
			{
				board.MoveCursor(1, 1);
			}
			else if (key == ConsoleKey.UpArrow)
			{
				board.MoveCursor(0, -1);
			}
			else if (key == ConsoleKey.DownArrow)
			{
				board.MoveCursor(0, 1);
			}
		}

		void DrawBoard()
		{
			var maxCoordY = board.Cells.Where(cell => cell.CoordX == 0).Max(cell => cell.CoordY);
			var currentCoordY = 0;
			var padLeft = 30;

			while (currentCoordY <= maxCoordY)
			{
				DrawLine(0, padLeft, 0, currentCoordY);
				DrawLine(1, padLeft, 0, currentCoordY);
				DrawLine(2, padLeft, 0, currentCoordY);
				DrawLine(3, padLeft, 0, currentCoordY);

				currentCoordY += 1;
			}
		}

		void DrawLine(int line, int padLeft, int startCoordX, int startCoordY)
		{
			var coordX = startCoordX;
			var coordY = startCoordY;

			for (var i = 0; i < padLeft; i++)
			{
				Console.Write(' ');
			}

			if (line == 0 || line == 3)
			{
				Console.Write(" ");
			}

			while (coordX <= board.MaxCoordX)
			{
				var cell = board.Cells.FirstOrDefault(cell => cell.CoordX == coordX && cell.CoordY == coordY);
				DrawCell(cell, line);

				if (line <= 1)
				{
					var adjacentCell = board.Cells.FirstOrDefault(cell => cell.CoordX == coordX + 1 && cell.CoordY == coordY);
					DrawCell(adjacentCell, line + 2);
				}
				else
				{
					var adjacentCell = board.Cells.FirstOrDefault(cell => cell.CoordX == coordX + 1 && cell.CoordY == coordY + 1);
					DrawCell(adjacentCell, line - 2);
				}

				coordX += 2;
				coordY += 1;
			}

			Console.WriteLine();
		}

		void DrawCell(Cell? cell, int line)
		{
			if (cell != null)
			{
				var cellLineInfo = cell[line];
				var oldBackground = Console.BackgroundColor;
				Console.BackgroundColor = cellLineInfo.GetCellLineColor();

				switch (line)
				{
					case 0:
						if (cell.IsSelected)
						{
							Console.ForegroundColor = cellSelectedColor;
						}
						Console.Write($"{cellLeftBorder}{cellTopBorder}{cellRightBorder}");
						Console.ForegroundColor = cellUnselectedColor;
						break;
					case 1:
					case 2:
						if (cell.IsSelected)
						{
							Console.ForegroundColor = cellSelectedColor;
						}
						Console.Write($"{cellLeftBorder}");
						Console.ForegroundColor = cellUnselectedColor;

						Console.Write($"{cellMiddle}");

						if (cell.IsSelected)
						{
							Console.ForegroundColor = cellSelectedColor;
						}
						Console.Write($"{cellRightBorder}");
						Console.ForegroundColor = cellUnselectedColor;
						break;
					case 3:
						if (cell.IsSelected)
						{
							Console.ForegroundColor = cellSelectedColor;
						}
						Console.Write($"{cellLeftBorder}{cellBottomBorder}{cellRightBorder}");
						Console.ForegroundColor = cellUnselectedColor;
						break;
				}

				Console.BackgroundColor = oldBackground;
			}
			else
			{
				if (line == 0 || line == 3)
				{
					Console.Write($"{emptyCellShort}");

				}
				else
				{
					Console.Write($"{emptyCell}");
				}
			}
		}

		void DrawLegend()
		{
			var oldBackground = Console.BackgroundColor;
			Console.BackgroundColor = ConsoleColor.Green;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.Write(" 树木  ");

			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.WriteLine(" 泥土");

			Console.BackgroundColor = ConsoleColor.Gray;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.Write(" 岩石  ");

			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.WriteLine(" 农田");

			Console.BackgroundColor = ConsoleColor.Red;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.Write(" 房屋  ");

			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.WriteLine(" 河流");

			Console.BackgroundColor = ConsoleColor.DarkYellow;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.Write(" 动物  ");

			Console.BackgroundColor = ConsoleColor.White;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.WriteLine(" 灵魂");

			var legendWidth = 20;
			var legendHeight = 4;
			Console.MoveBufferArea(0, Console.CursorTop - legendHeight, legendWidth, legendHeight, 0, 4);
		}

		void DrawCursorDetails()
		{
			var selectedCell = board.Cells.FirstOrDefault(cell => cell.IsSelected);
			if (selectedCell != null)
			{
				Console.WriteLine($"当前格坐标 {selectedCell.CoordX},{selectedCell.CoordY}");

				var placedTokenDetailsHeight = 0;
				var placedLines = selectedCell.Lines.Where(line => !line.IsEmpty).OrderBy(line => line.Line);
				if (placedLines.Any())
				{
					Console.WriteLine();
					Console.WriteLine("已放置标记");
					foreach (var placedLine in placedLines)
					{
						Console.Write($"{4 - placedLine.Line}层 ");
						var oldBackground = Console.BackgroundColor;
						Console.BackgroundColor = placedLine.CellLineInfo.GetCellLineColor();
						Console.WriteLine("    ");
						Console.BackgroundColor = oldBackground;
					}

					placedTokenDetailsHeight = 2 + placedLines.Count();
				}

				var detailsWidth = 20;
				var detailsHeight = 1 + placedTokenDetailsHeight;
				Console.MoveBufferArea(0, Console.CursorTop - detailsHeight, detailsWidth, detailsHeight, 0, 10);
			}
		}

		const string cellLeftBorder = "[";
		const string cellRightBorder = "]";
		const string cellTopBorder = "----";
		const string cellBottomBorder = "====";
		const string cellMiddle = "      ";
		const string emptyCellShort = "      ";
		const string emptyCell = "        ";

		ConsoleColor cellSelectedColor = ConsoleColor.Magenta;
		ConsoleColor cellUnselectedColor = ConsoleColor.White;
	}
}
