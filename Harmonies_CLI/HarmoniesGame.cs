namespace Harmonies_CLI
{
	class HarmoniesGame
	{
		public HarmoniesGame()
		{
			boardPanel = new BoardPanel(new Board_TypeA());
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
			boardPanel.Draw();
		}

		void ProcessKeyInput(ConsoleKey key)
		{
			boardPanel.ProcessKey(key);
		}

		bool IsGameEnd => false;

		IPanel boardPanel;
	}
}
