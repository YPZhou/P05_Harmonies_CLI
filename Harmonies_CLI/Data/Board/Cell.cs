namespace Harmonies_CLI
{
	class Cell
	{
		public Cell(int coordX, int coordY)
		{
			CoordX = coordX;
			CoordY = coordY;

			IsSelected = false;
		}

		public void ToggleSelection()
		{
			IsSelected = !IsSelected;
		}

		public int CoordX { get; }
		public int CoordY { get; }

		public bool IsSelected { get; private set; }
	}
}
