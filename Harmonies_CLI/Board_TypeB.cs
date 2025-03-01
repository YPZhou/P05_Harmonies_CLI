﻿namespace Harmonies_CLI
{
	class Board_TypeB : Board
	{
		// Blue type B board
		//Console.WriteLine(" [----]        [----]        [----]        [----]");
		//Console.WriteLine("[ 0  0 ]      [ 2  1 ]      [ 4  2 ]      [ 6  3 ]");
		//Console.WriteLine("[      ][----][      ][----][      ][----][      ]");
		//Console.WriteLine(" [====][ 1  1 ][====][ 3  2 ][====][ 5  3 ][====]");
		//Console.WriteLine(" [----][      ][----][      ][----][      ][----]");
		//Console.WriteLine("[ 0  1 ][====][ 2  2 ][====][ 4  3 ][====][ 6  4 ]");
		//Console.WriteLine("[      ][----][      ][----][      ][----][      ]");
		//Console.WriteLine(" [====][ 1  2 ][====][ 3  3 ][====][ 5  4 ][====]");
		//Console.WriteLine(" [----][      ][----][      ][----][      ][----]");
		//Console.WriteLine("[ 0  2 ][====][ 2  3 ][====][ 4  4 ][====][ 6  5 ]");
		//Console.WriteLine("[      ][----][      ][----][      ][----][      ]");
		//Console.WriteLine(" [====][ 1  3 ][====][ 3  4 ][====][ 5  5 ][====]");
		//Console.WriteLine(" [----][      ][----][      ][----][      ][----]");
		//Console.WriteLine("[ 0  3 ][====][ 2  4 ][====][ 4  5 ][====][ 6  6 ]");
		//Console.WriteLine("[      ]      [      ]      [      ]      [      ]");
		//Console.WriteLine(" [====]        [====]        [====]        [====]");

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
