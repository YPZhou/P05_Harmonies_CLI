namespace Harmonies_CLI
{
	abstract class Board
	{
		public Board()
		{
			CreateCells();

			var topLeftCell = Cells.MinBy(cell => cell.CoordX + cell.CoordY);
			if (topLeftCell != null)
			{
				cursorX = topLeftCell.CoordX;
				cursorY = topLeftCell.CoordY;
				topLeftCell.ToggleSelection();
			}
		}

		protected abstract void CreateCells();

		public void DrawBoard()
		{
			var maxCoordY = Cells.Where(cell => cell.CoordX == 0).Max(cell => cell.CoordY);
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

		public void MoveCursor(int deltaX, int deltaY)
		{
			var selectedCell = Cells.FirstOrDefault(cell => cell.IsSelected);
			
			var newCursorX = cursorX + deltaX;
			var newCursorY = cursorY + deltaY;
			var newSelectedCell = Cells.FirstOrDefault(cell => cell.CoordX == newCursorX && cell.CoordY == newCursorY);
			if (newSelectedCell != null)
			{
				newSelectedCell.ToggleSelection();
				cursorX = newCursorX;
				cursorY = newCursorY;

				selectedCell?.ToggleSelection();
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

			while (coordX <= MaxCoordX)
			{
				var cell = Cells.FirstOrDefault(cell => cell.CoordX == coordX && cell.CoordY == coordY);
				DrawCell(cell, line);

				if (line <= 1)
				{
					var adjacentCell = Cells.FirstOrDefault(cell => cell.CoordX == coordX + 1 && cell.CoordY == coordY);
					DrawCell(adjacentCell, line + 2);
				}
				else
				{
					var adjacentCell = Cells.FirstOrDefault(cell => cell.CoordX == coordX + 1 && cell.CoordY == coordY + 1);
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
						Console.Write("[----]");
						Console.ForegroundColor = cellUnselectedColor;
						break;
					case 1:
					case 2:
						if (cell.IsSelected)
						{
							Console.ForegroundColor = cellSelectedColor;
						}
						Console.Write("[");
						Console.ForegroundColor = cellUnselectedColor;

						Console.Write("      ");

						if (cell.IsSelected)
						{
							Console.ForegroundColor = cellSelectedColor;
						}
						Console.Write("]");
						Console.ForegroundColor = cellUnselectedColor;
						break;
					case 3:
						if (cell.IsSelected)
						{
							Console.ForegroundColor = cellSelectedColor;
						}
						Console.Write("[====]");
						Console.ForegroundColor = cellUnselectedColor;
						break;
				}
			}
			else
			{
				if (line == 0 || line == 3)
				{
					Console.Write("      ");

				}
				else
				{
					Console.Write("        ");
				}
			}
		}

		int MaxCoordX => Cells.Max(cell => cell.CoordX);

		int cursorX;
		int cursorY;

		ConsoleColor cellSelectedColor = ConsoleColor.Magenta;
		ConsoleColor cellUnselectedColor = ConsoleColor.White;

		protected List<Cell> Cells => cells ??= new List<Cell>();
		List<Cell>? cells;
	}
}
