﻿namespace Harmonies_CLI
{
	class Board_TypeA : Board
	{
		protected override void CreateCells()
		{
			Cells.AddRange(
			[
				new Cell(0, 0),
				new Cell(0, 1),
				new Cell(0, 2),
				new Cell(0, 3),
				new Cell(0, 4),

				new Cell(1, 1),
				new Cell(1, 2),
				new Cell(1, 3),
				new Cell(1, 4),

				new Cell(2, 1),
				new Cell(2, 2),
				new Cell(2, 3),
				new Cell(2, 4),
				new Cell(2, 5),

				new Cell(3, 2),
				new Cell(3, 3),
				new Cell(3, 4),
				new Cell(3, 5),
				
				new Cell(4, 2),
				new Cell(4, 3),
				new Cell(4, 4),
				new Cell(4, 5),
				new Cell(4, 6),
			]);
		}
	}
}
