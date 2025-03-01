namespace Harmonies_CLI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Areas
			// 1 Terrain token supplier
			// 2 Animal card supplier
			// 3 Player board
			// 4 Player animal cards
			// 5 Player unplaced terrain tokens

			// UI & Interactions
			//
			// * Player board is always visible
			// * Press F1-F4 to switch between players if more than one player
			// * Disable Fn keys if only one player
			//
			// * Press 1 to show terrain token supplier
			// * Press 2 to show animal card supplier
			// * Press 3 to show current player's animal cards
			// * Press 4 to show current player's unplaced terrain tokens
			//
			// * Press tab to switch focus between areas
			//
			// * For player board, arrow keys to move cursor
			//   space key to place terrain token if an unplaced token is selected
			//   or space key to place animal cube if an animal card is selected
			// * For terrain token supplier, arrow keys to move cursor, space key to select terrain token pile
			// * For animal card supplier, arrow keys to move cursor, space key to select animal card
			// * For player animal cards, arrow keys to move cursor, space key to select animal cube
			//   this will also cancel selection of terrain token if one is selected
			// * For player unplaced terrain tokens, arrow keys to move cursor, space key to select terrain token
			//   this will also cancel selection of animal cube if one is selected

			var game = new HarmoniesGame();
			game.Run();
		}
	}
}
