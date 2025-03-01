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

		public int MaxCoordX => Cells.Max(cell => cell.CoordX);

		public List<Cell> Cells => cells ??= new List<Cell>();
		List<Cell>? cells;

		int cursorX;
		int cursorY;
	}
}
