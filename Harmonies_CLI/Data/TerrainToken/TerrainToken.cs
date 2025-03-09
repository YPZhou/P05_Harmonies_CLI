using static Harmonies_CLI.Constants;

namespace Harmonies_CLI
{
	class TerrainToken
	{
		public TerrainToken(TerrainType terrainType)
		{
			TerrainType = terrainType;
		}

		public TerrainType TerrainType { get; }
	}
}
