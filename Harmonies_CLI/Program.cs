namespace Harmonies_CLI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Yellow type A board
			//Console.WriteLine(" [----]        [----]        [----]");
			//Console.WriteLine("[ 0  0 ]      [ 2  1 ]      [ 4  2 ]");
			//Console.WriteLine("[      ][----][      ][----][      ]");
			//Console.WriteLine(" [====][ 1  1 ][====][ 3  2 ][====]");
			//Console.WriteLine(" [----][      ][----][      ][----]");
			//Console.WriteLine("[ 0  1 ][====][ 2  2 ][====][ 4  3 ]");
			//Console.WriteLine("[      ][----][      ][----][      ]");
			//Console.WriteLine(" [====][ 1  2 ][====][ 3  3 ][====]");
			//Console.WriteLine(" [----][      ][----][      ][----]");
			//Console.WriteLine("[ 0  2 ][====][ 2  3 ][====][ 4  4 ]");
			//Console.WriteLine("[      ][----][      ][----][      ]");
			//Console.WriteLine(" [====][ 1  3 ][====][ 3  4 ][====]");
			//Console.WriteLine(" [----][      ][----][      ][----]");
			//Console.WriteLine("[ 0  3 ][====][ 2  4 ][====][ 4  5 ]");
			//Console.WriteLine("[      ][----][      ][----][      ]");
			//Console.WriteLine(" [====][ 1  4 ][====][ 3  5 ][====]");
			//Console.WriteLine(" [----][      ][----][      ][----]");
			//Console.WriteLine("[ 0  4 ][====][ 2  5 ][====][ 4  6 ]");
			//Console.WriteLine("[      ]      [      ]      [      ]");
			//Console.WriteLine(" [====]        [====]        [====]");

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

			//var board = new Board_TypeA();
			var board = new Board_TypeB();
			board.DrawBoard();
		}
	}
}
