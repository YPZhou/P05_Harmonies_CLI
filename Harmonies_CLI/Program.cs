namespace Harmonies_CLI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Yellow board
			Console.WriteLine(" [----]        [----]        [----]");   // Empty 2, (0, 0) lv4 6, Empty 8, (2, 1) lv4, 6, Empty 8, (4, 2) lv4 6
			Console.WriteLine("[ 0  0 ]      [ 2  1 ]      [ 4  2 ]");  // (0, 0) lv3 8, Empty 6, (2, 1) lv3 8, Empty 6, (4, 2) lv3 8
			Console.WriteLine("[      ][----][      ][----][      ]");  // (0, 0) lv2 8, (1, 1) lv4 8, (2, 1) lv2 8, (3, 2) lv4 6, (4, 2) lv2 8
			Console.WriteLine(" [====][ 1  1 ][====][ 3  2 ][====]");   // Empty 2, (0, 0) lv1 6, (1, 1) lv3 8, (2, 1) lv1 6, (3, 2) lv3 8, (4, 2) lv1 6
			Console.WriteLine(" [----][      ][----][      ][----]");   // Empty 2, (0, 1) lv4 6, (1, 1) lv2 8, (2, 2) lv4 6, (3, 2) lv2 8, (4, 3) lv4 6
			Console.WriteLine("[ 0  1 ][====][ 2  2 ][====][ 4  3 ]");  // (0, 1) lv3 8, (1, 1) lv1 6, (2, 2) lv3 8, (3, 2) lv1 6, (4, 3) lv3 8
			Console.WriteLine("[      ][----][      ][----][      ]");  // (0, 1) lv2 8, (1, 2) lv4 6, (2, 2) lv2 8, (3, 3) lv4 6, (4, 3) lv2 8
			Console.WriteLine(" [====][ 1  2 ][====][ 3  3 ][====]");   // Empty 2, (0, 1) lv1 6, (1, 2) lv3 8, (2, 2) lv1 6, (3, 3) lv3 8, (4, 3) lv1 6
			Console.WriteLine(" [----][      ][----][      ][----]");   // Empty 2, (0, 2) lv4 6, (1, 2) lv2 8, (2, 3) lv4 6, (3, 3) lv2 8, (4, 4) lv4 6
			Console.WriteLine("[ 0  2 ][====][ 2  3 ][====][ 4  4 ]");  // (0, 2) lv3 8, (1, 2) lv1 6, (2, 3) lv3 8, (3, 3) lv1 6, (4, 4) lv3 8
			Console.WriteLine("[      ][----][      ][----][      ]");  // (0, 2) lv2 8, (1, 3) lv4 6, (2, 3) lv2 8, (3, 4) lv4 6, (4, 4) lv2 8
			Console.WriteLine(" [====][ 1  3 ][====][ 3  4 ][====]");   // Empty 2, (0, 2) lv1 6, (1, 3) lv3 8, (2, 3) lv1 6, (3, 4) lv3 8, (4, 4) lv1 6
			Console.WriteLine(" [----][      ][----][      ][----]");   // Empty 2, (0, 3) lv4 6, (1, 3) lv2 8, (2, 4) lv4 6, (3, 4) lv2 8, (4, 5) lv4 6
			Console.WriteLine("[ 0  3 ][====][ 2  4 ][====][ 4  5 ]");  // (0, 3) lv3 8, (1, 3) lv1 6, (2, 4) lv3 8, (3, 4) lv1 6, (4, 5) lv3 8
			Console.WriteLine("[      ][----][      ][----][      ]");  // (0, 3) lv2 8, (1, 4) lv4 6, (2, 4) lv2 8, (3, 5) lv4 6, (4, 5) lv2 8
			Console.WriteLine(" [====][ 1  4 ][====][ 3  5 ][====]");   // Empty 2, (0, 3) lv1 6, (1, 4) lv3 8, (2, 4) lv1 6, (3, 5) lv3 8, (4, 5) lv1 6
			Console.WriteLine(" [----][      ][----][      ][----]");   // Empty 2, (0, 4) lv4 6, (1, 4) lv2 8, (2, 5) lv4 6, (3, 5) lv2 8, (4, 6) lv4 6
			Console.WriteLine("[ 0  4 ][====][ 2  5 ][====][ 4  6 ]");  // (0, 4) lv3 8, (1, 4) lv1 6, (2, 5) lv3 8, (3, 5) lv1 6, (4, 6) lv3 8
			Console.WriteLine("[      ]      [      ]      [      ]");  // (0, 4) lv2 8, Empty 6, (2, 5) lv2 8, Empty 6, (4, 6) lv2 8
			Console.WriteLine(" [====]        [====]        [====]");   // Empty 2, (0, 4) lv1 6, Empty 8, (2, 5) lv1 6, Empty 8, (4, 6) lv1 6

			// Blue board
			//Console.WriteLine(" [----]        [----]        [----]        [----]");   // Empty 2, (0, 0) lv4 6, Empty 8, (2, 1) lv4 6, Empty 8, (4, 2) lv4 6, Empty 8, (6, 3) lv4 6
			//Console.WriteLine("[ 0  0 ]      [ 2  1 ]      [ 4  2 ]      [ 6  3 ]");  // (0, 0) lv3 8, Empty 6, (2, 1) lv3 8, Empty 6, (4, 2) lv3 8, Empty 6, (6, 3) lv3 8
			//Console.WriteLine("[      ][----][      ][----][      ][----][      ]");  // (0, 0) lv2 8, (1, 1) lv4 6, (2, 1) lv2 8, (3, 2) lv4 6, (4, 2) lv2 8, (5, 3) lv4 6, (6, 3) lv2 8
			//Console.WriteLine(" [====][ 1  1 ][====][ 3  2 ][====][ 5  3 ][====]");   // Empty 2, (0, 0) lv1 6, (1, 1) lv3 8, (2, 1) lv1 6, (3, 2) lv3 8, (4, 2) lv1 6, (5, 3) lv3 8, (6, 3) lv1 6
			//Console.WriteLine(" [----][      ][----][      ][----][      ][----]");   // Empty 2, (0, 1) lv4 6, (1, 1) lv2 8, (2, 2) lv4 6, (3, 2) lv2 8, (4, 3) lv4 6, (5, 3) lv2 8, (6, 4) lv4 6
			//Console.WriteLine("[ 0  1 ][====][ 2  2 ][====][ 4  3 ][====][ 6  4 ]");  // (0, 1) lv3 8, (1, 1) lv1 6, (2, 2) lv3 8, (3, 2) lv1 6, (4, 3) lv3 8, (5, 3) lv1 6, (6, 4) lv3 8
			//Console.WriteLine("[      ][----][      ][----][      ][----][      ]");  // (0, 1) lv2 8, (1, 2) lv4 6, (2, 2) lv2 8, (3, 3) lv4 6, (4, 3) lv2 8, (5, 4) lv4 6, (6, 4) lv2 8
			//Console.WriteLine(" [====][ 1  2 ][====][ 3  3 ][====][ 5  4 ][====]");   // Empty 2, (0, 1) lv1 6, (1, 2) lv3 8, (2, 2) lv1 6, (3, 3) lv3 8, (4, 3) lv1 6, (5, 4) lv3 8, (6, 4) lv1 6
			//Console.WriteLine(" [----][      ][----][      ][----][      ][----]");   // Empty 2, (0, 2) lv4 6, (1, 2) lv2 8, (2, 3) lv4 6, (3, 3) lv2 8, (4, 4) lv4 6, (5, 4) lv2 8, (6, 5) lv4 6
			//Console.WriteLine("[ 0  2 ][====][ 2  3 ][====][ 4  4 ][====][ 6  5 ]");  // (0, 2) lv3 8, (1, 2) lv1 6, (2, 3) lv3 8, (3, 3) lv1 6, (4, 4) lv3 8, (5, 4) lv1 6, (6, 5) lv3 8
			//Console.WriteLine("[      ][----][      ][----][      ][----][      ]");  // (0, 2) lv2 8, (1, 3) lv4 6, (2, 3) lv2 8, (3, 4) lv4 6, (4, 4) lv2 8, (5, 5) lv4 6, (6, 5) lv2 8
			//Console.WriteLine(" [====][ 1  3 ][====][ 3  4 ][====][ 5  5 ][====]");   // Empty 2, (0, 2) lv1 6, (1, 3) lv3 8, (2, 3) lv1 6, (3, 4) lv3 8, (4, 4) lv1 6, (5, 5) lv3 8, (6, 5) lv1 6
			//Console.WriteLine(" [----][      ][----][      ][----][      ][----]");   // Empty 2, (0, 3) lv4 6, (1, 3) lv2 8, (2, 4) lv4 6, (3, 4) lv2 8, (4, 5) lv4 6, (5, 5) lv2 8, (6, 6) lv4 6
			//Console.WriteLine("[ 0  3 ][====][ 2  4 ][====][ 4  5 ][====][ 6  6 ]");  // (0, 3) lv3 8, (1, 3) lv1 6, (2, 4) lv3 8, (3, 4) lv1 6, (4, 5) lv3 8, (5, 5) lv1 6, (6, 6) lv3 8
			//Console.WriteLine("[      ]      [      ]      [      ]      [      ]");  // (0, 3) lv2 8, Empty 6, (2, 4) lv2 8, Empty 6, (4, 5) lv2 8, Empty 6, (6, 6) lv2 8
			//Console.WriteLine(" [====]        [====]        [====]        [====]");   // Empty 2, (0, 3) lv1 6, Empty 8, (2, 4) lv1 6, Empty 8, (4, 5) lv1 6, Empty 8, (6, 6) lv1 6
		}
	}
}
