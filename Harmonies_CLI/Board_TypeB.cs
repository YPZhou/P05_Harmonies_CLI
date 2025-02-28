namespace Harmonies_CLI
{
	class Board_TypeB : Board
	{
		protected override void CreateCells()
		{
			Cells.AddRange(
			[
				new Cell(0, 0),
				new Cell(0, 1),
				new Cell(0, 2),
				new Cell(0, 3),

				new Cell(1, 1),
				new Cell(1, 2),
				new Cell(1, 3),

				new Cell(2, 1),
				new Cell(2, 2),
				new Cell(2, 3),
				new Cell(2, 4),

				new Cell(3, 2),
				new Cell(3, 3),
				new Cell(3, 4),

				new Cell(4, 2),
				new Cell(4, 3),
				new Cell(4, 4),
				new Cell(4, 5),

				new Cell(5, 3),
				new Cell(5, 4),
				new Cell(5, 5),

				new Cell(6, 3),
				new Cell(6, 4),
				new Cell(6, 5),
				new Cell(6, 6),
			]);
		}
	}
}
