namespace Harmonies_CLI
{
	class HarmoniesGame
	{
		public HarmoniesGame()
		{
			// board = new Board_TypeA();
			board = new Board_TypeB();
		}

		public void Run()
		{
			while (!IsGameEnd)
			{
				DrawUI();

				var key = Console.ReadKey(intercept: true).Key;
				ProcessKeyInput(key);
			}
		}

		void DrawUI()
		{
			Console.Clear();
			board.DrawBoard();
		}

		void ProcessKeyInput(ConsoleKey key)
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

		bool IsGameEnd => false;

		Board board;
	}
}
