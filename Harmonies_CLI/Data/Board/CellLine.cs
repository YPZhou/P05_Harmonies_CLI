using static Harmonies_CLI.Constants;

namespace Harmonies_CLI
{
	class CellLine
	{
		public CellLine(int line)
		{
			Line = line;
		}

		public void PlaceTerrainToken(TerrainToken terrainToken)
		{
			if (IsEmpty)
			{
				this.terrainToken = terrainToken;
			}
		}

		public int Line { get; }

		public CellLineInfo CellLineInfo
		{
			get
			{
				var result = CellLineInfo.EMPTY;
				if (terrainToken != null)
				{
					result = Enum.Parse<CellLineInfo>(terrainToken.TerrainType.ToString());
				}

				return result;
			}
		}

		public bool IsEmpty => terrainToken == null;

		TerrainToken? terrainToken;
	}
}
