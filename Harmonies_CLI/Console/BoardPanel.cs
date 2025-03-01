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

			while (currentCoordY <= maxCoordY)
			{
				DrawLine(0, 0, currentCoordY);
				DrawLine(1, 0, currentCoordY);
				DrawLine(2, 0, currentCoordY);
				DrawLine(3, 0, currentCoordY);

				currentCoordY += 1;
			}
		}

		void DrawLine(int line, int startCoordX, int startCoordY)
		{
			var coordX = startCoordX;
			var coordY = startCoordY;

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
