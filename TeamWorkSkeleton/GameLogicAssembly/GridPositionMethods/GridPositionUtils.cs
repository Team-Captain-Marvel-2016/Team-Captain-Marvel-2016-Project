namespace GameLogicAssembly.GridPositionMethods
{
    using GlobalDataStructures;
    using PlayingFIeldAssembly;
    using PlayingFieldMethodsAssembly;
    using System;
    using System.Collections.Generic;
    using VisualizationInterfacesAssembly.CanvasVisualizationInterfaces;

    public static class GridPositionUtils
    {
        public static bool HasObjectsInRange(IDrawOnCanvas obj)
        {
            var playerRow = obj.GridPosition.X;
            var playerCol = obj.GridPosition.Y;

            for (var row = Math.Max(playerRow - 1, 0); row <= Math.Min(playerRow + 1, 8); row++)
            {
                for (var col = Math.Max(playerCol - 1, 0); col <= Math.Min(playerCol + 1, 14); col++)
                {
                    if (row == playerRow && col == playerCol)
                    {
                        continue;
                    }
                    else if (PlayingField.Field[row, col])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static IEnumerable<PositionXY> FindObjectsInRange(IDrawOnCanvas obj, IDrawOnCanvas target)
        {
            var objRow = obj.GridPosition.X;
            var objCol = obj.GridPosition.Y;

            var targetRow = target.GridPosition.X;
            var targetCol = target.GridPosition.Y;

            Func<int, int, IEnumerable<PositionXY>> func = null;

            if (objCol == targetCol && objRow < targetRow) func = Up;
            else if (objCol == targetCol && objRow > targetRow) func = Down;
            else if (objCol > targetCol && objRow == targetRow) func = Left;
            else if (objCol < targetCol && objRow == targetRow) func = Right;
            else if (objCol < targetCol && objRow < targetRow) func = UpRight;
            else if (objCol > targetCol && objRow < targetRow) func = DownRight;
            else if (objCol < targetCol && objRow > targetRow) func = DownRight;
            else if (objCol > targetCol && objRow > targetRow) func = DownLeft;
            
            var output = func?.Invoke(objRow, objCol);

            if (output == null) throw new ApplicationException("Inavlid input");

            return output;
        }

        private static IEnumerable<PositionXY> Up(int row, int col)
        {
            var startRow = row - 2;
            var startCol = col - 1;

            return GetList(startRow, startCol);
        }

        private static IEnumerable<PositionXY> Down(int row, int col)
        {
            var startRow = row + 2;
            var startCol = col - 1;

            return GetList(startRow, startCol);
        }

        private static IEnumerable<PositionXY> Left(int row, int col)
        {
            var startRow = row - 1;
            var startCol = col - 2;

            return GetList(startRow, startCol);
        }

        private static IEnumerable<PositionXY> Right(int row, int col)
        {
            var startRow = row - 1;
            var startCol = col + 2;

            return GetList(startRow, startCol);
        }

        private static IEnumerable<PositionXY> UpRight(int row, int col)
        {
            var startRow = row - 2;
            var startCol = col;

            return GetList(startRow, startCol);
        }

        private static IEnumerable<PositionXY> UpLeft(int row, int col)
        {
            var startRow = row - 2;
            var startCol = col - 2;

            return GetList(startRow, startCol);
        }

        private static IEnumerable<PositionXY> DownRight(int row, int col)
        {
            var startRow = row + 2;
            var startCol = col;

            return GetList(startRow, startCol);
        }

        private static IEnumerable<PositionXY> DownLeft(int row, int col)
        {
            var startRow = row + 2;
            var startCol = col - 2;

            return GetList(startRow, startCol);
        }

        private static IEnumerable<PositionXY> GetList(int startRow, int startCol)
        {
            return PlayingFieldMethods.FindOccupiedPositionsInRange(startRow, startCol);
        }
    }
}
