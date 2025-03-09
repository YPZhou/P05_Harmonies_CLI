using static Harmonies_CLI.Constants;

namespace Harmonies_CLI
{
	public static class Extensions
	{
		public static ConsoleColor GetCellLineColor(this CellLineInfo cellLineInfo)
		{
			var result = ConsoleColor.DarkGray;
			switch (cellLineInfo)
			{
				case CellLineInfo.WOOD:
					result = ConsoleColor.Green;
					break;
				case CellLineInfo.DIRT:
					result = ConsoleColor.DarkRed;
					break;
				case CellLineInfo.ROCK:
					result = ConsoleColor.Gray;
					break;
				case CellLineInfo.FARM:
					result = ConsoleColor.Yellow;
					break;
				case CellLineInfo.HOUSE:
					result = ConsoleColor.Red;
					break;
				case CellLineInfo.WATER:
					result = ConsoleColor.Blue;
					break;
				case CellLineInfo.ANIMAL:
					result = ConsoleColor.DarkYellow;
					break;
				case CellLineInfo.SPIRIT:
					result = ConsoleColor.White;
					break;
			}

			return result;
		}
	}
}
