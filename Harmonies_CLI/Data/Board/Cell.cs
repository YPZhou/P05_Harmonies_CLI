using static Harmonies_CLI.Constants;

namespace Harmonies_CLI
{
	class Cell
	{
		public Cell(int coordX, int coordY)
		{
			CoordX = coordX;
			CoordY = coordY;

			IsSelected = false;

			var rand = new Random();
			PlaceTerrainToken(new TerrainToken((TerrainType)rand.Next(6)));

			if (rand.Next(10) > 5)
			{
				PlaceTerrainToken(new TerrainToken((TerrainType)rand.Next(6)));
			}
		}

		public void ToggleSelection()
		{
			IsSelected = !IsSelected;
		}

		public void PlaceTerrainToken(TerrainToken terrainToken)
		{
			TopEmptyLine?.PlaceTerrainToken(terrainToken);
		}

		public CellLineInfo this[int index]
		{
			get
			{
				return Lines.First(line => line.Line == index).CellLineInfo;
			}
		}

		public int CoordX { get; }
		public int CoordY { get; }

		public bool IsSelected { get; private set; }

		public IEnumerable<CellLine> Lines
		{
			get
			{
				if (lines == null)
				{
					lines = new List<CellLine>();
					for (var i = 0; i < 4; i++)
					{
						lines.Add(new CellLine(i));
					}
				}

				return lines;
			}
		}

		List<CellLine>? lines;

		CellLine? TopEmptyLine => Lines.OrderByDescending(line => line.Line).FirstOrDefault(line => line.IsEmpty);
	}
}
