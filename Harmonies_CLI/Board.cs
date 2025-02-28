namespace Harmonies_CLI
{
	abstract class Board
	{
		public Board()
		{
			CreateCells();
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
						Console.Write("[----]");
						break;
					case 1:
					case 2:
						Console.Write("[      ]");
						break;
					case 3:
						Console.Write("[====]");
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

		protected List<Cell> Cells => cells ??= new List<Cell>();
		List<Cell>? cells;
	}
}
