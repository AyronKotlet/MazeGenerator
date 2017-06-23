﻿using MazeGenerator;
using System.Windows.Media;

namespace MazeGeneratorMVVM.ViewModel
{
    class CellItem
    {
        public Cell Cell { get; private set; }
        public CellItem(Cell cell)
        {
            Cell = cell;
            NorthWall = Cell.ContainsWall(Direction.North);
            SouthWall = Cell.ContainsWall(Direction.South);
            EastWall = Cell.ContainsWall(Direction.East);
            WestWall = Cell.ContainsWall(Direction.West);
        }

        public double Top { get; set; }
        public double Left { get; set; }
        public double Width { get; set; }
        public bool NorthWall { get; private set; }
        public bool SouthWall { get; private set; }
        public bool EastWall { get; private set; }
        public bool WestWall { get; private set; }
        public SolidColorBrush Background { get; set; }
    }
}
