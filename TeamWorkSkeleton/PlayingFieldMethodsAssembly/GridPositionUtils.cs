namespace Game.PlayingField.Methods
{
    using System;
    using System.Collections.Generic;
    using Global.Contracts;
    using Global.DataStructures;

    /// <summary>
    /// Static Methods working with PlayingField
    /// </summary>
    public static class GridPositionUtils
    {
        /// <summary>
        /// Checks all neighbouring grid cells for 
        /// objects.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Whether an object is present in a neighbouring cell.</returns>
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

        /// <summary>
        /// Used for Passing.
        /// Checks an area around the current object.
        /// Area depends on the direction of the pass.
        /// This Method determines which area to check, 
        /// and passes it along.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="target"></param>
        /// <returns></returns>
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
            else if (objCol < targetCol && objRow > targetRow) func = UpRight;
            else if (objCol < targetCol && objRow < targetRow) func = DownRight;
            else if (objCol > targetCol && objRow > targetRow) func = UpLeft;
            else if (objCol > targetCol && objRow < targetRow) func = DownLeft;
            
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
            var startRow = row;
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
            var startCol = col;

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
            var startRow = row;
            var startCol = col;

            return GetList(startRow, startCol);
        }

        private static IEnumerable<PositionXY> DownLeft(int row, int col)
        {
            var startRow = row;
            var startCol = col - 2;

            return GetList(startRow, startCol);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startRow"></param>
        /// <param name="startCol"></param>
        /// <returns> List of PositionXY objects with occupied PlayingField Grid postions</returns>
        private static IEnumerable<PositionXY> GetList(int startRow, int startCol)
        {
            return PlayingFieldMethods.FindOccupiedPositionsInRange(startRow, startCol);
        }
    }
}
