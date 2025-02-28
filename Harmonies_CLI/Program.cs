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

			//var board = new Board_TypeA();
			var board = new Board_TypeB();
			board.DrawBoard();
		}
	}
}
