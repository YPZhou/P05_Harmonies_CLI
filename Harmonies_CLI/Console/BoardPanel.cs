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
			var padLeft = 20;

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
				switch (cellLineInfo)
				{
					case CellLineInfo.EMPTY:
						Console.BackgroundColor = ConsoleColor.DarkGray;
						break;
					case CellLineInfo.WOOD:
						Console.BackgroundColor = ConsoleColor.Green;
						break;
					case CellLineInfo.DIRT:
						Console.BackgroundColor = ConsoleColor.DarkRed;
						break;
					case CellLineInfo.ROCK:
						Console.BackgroundColor = ConsoleColor.Gray;
						break;
					case CellLineInfo.FARM:
						Console.BackgroundColor = ConsoleColor.Yellow;
						break;
					case CellLineInfo.HOUSE:
						Console.BackgroundColor = ConsoleColor.Red;
						break;
					case CellLineInfo.WATER:
						Console.BackgroundColor = ConsoleColor.Blue;
						break;
					case CellLineInfo.ANIMAL:
						Console.BackgroundColor = ConsoleColor.DarkYellow;
						break;
					case CellLineInfo.SPIRIT:
						Console.BackgroundColor = ConsoleColor.White;
						break;
				}

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
			Console.Write(" 树  ");

			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.WriteLine(" 土");

			Console.BackgroundColor = ConsoleColor.Gray;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.Write(" 石  ");

			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.WriteLine(" 田");

			Console.BackgroundColor = ConsoleColor.Red;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.Write(" 房  ");

			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.WriteLine(" 河");

			Console.BackgroundColor = ConsoleColor.DarkYellow;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.Write(" 动  ");

			Console.BackgroundColor = ConsoleColor.White;
			Console.Write("    ");
			Console.BackgroundColor = oldBackground;
			Console.WriteLine(" 魂");

			Console.MoveBufferArea(0, Console.CursorTop - 4, 16, 4, 0, 4);
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
