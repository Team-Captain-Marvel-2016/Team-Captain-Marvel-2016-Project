namespace Game.PlayingField.Methods
{
    using System;
    using System.Collections.Generic;
    using Game.PlayingField;
    using Global.Contracts;
    using Global.DataStructures;

    public static class PlayingFieldMethods
    {
        /// <summary>
        /// Marks the positions of all IDrawOnCanvas object in a collection,
        /// into the PlayingField bool[].
        /// </summary>
        /// <param name="collection"></param>
        public static void MarkAllPlayersFromTeam(IEnumerable<IDrawOnCanvas> collection)
        {
            foreach (var footballPlayer in collection)
            {
                int row, col;
                GetPlayerXY(footballPlayer, out row, out col);

                PlayingField.Field[row, col] = true;
            }
        }

        /// <summary>
        /// Clears the current positions of all IDrawOnCanvas objects in a collection
        /// from the PlayingFields bool[].
        /// </summary>
        /// <param name="collection"></param>
        public static void UnMarkAllPlayersFromTeam(IEnumerable<IDrawOnCanvas> collection)
        {
            foreach (var footballPlayer in collection)
            {
                int row, col;
                GetPlayerXY(footballPlayer, out row, out col);

                PlayingField.Field[row, col] = false;
            }
        }

        /// <summary>
        /// Mark a single IDrawOnCanvas object 
        /// on the PlayingField grid.
        /// </summary>
        /// <param name="player"></param>
        public static void MarkPlayerPosition(IDrawOnCanvas player)
        {
            int row, col;
            GetPlayerXY(player, out row, out col);

            PlayingField.Field[row, col] = true;
        }

        /// <summary>
        /// Unmark a single IDrawOnCanvas object 
        /// on the PlayingField grid.
        /// </summary>
        /// <param name="player"></param>
        public static void UnMarkPlayerPosition(IDrawOnCanvas player)
        {
            int row, col;
            GetPlayerXY(player, out row, out col);

            PlayingField.Field[row, col] = false;
        }

        /// <summary>
        /// Toggle player postions of a particular object.
        /// Not used.
        /// </summary>
        /// <param name="player"></param>
        public static void TogglePlayerPosition(IDrawOnCanvas player)
        {
            int row, col;
            GetPlayerXY(player, out row, out col);

            PlayingField.Field[row, col] = !PlayingField.Field[row, col];
        }

        /// <summary>
        /// Update the positions of all IDrawOnCanvas objects
        /// on the PlayingField grid.
        /// Unmark all, then mark them anew.
        /// </summary>
        /// <param name="collection"></param>
        public static void UpdateAllPlayers(IEnumerable<IDrawOnCanvas> collection)
        {
            UnMarkAllPlayersFromTeam(collection);
            MarkAllPlayersFromTeam(collection);
        }

        /// <summary>
        /// Convert PositionXY to tow separate ints.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void GetPlayerXY(IDrawOnCanvas player, out int x, out int y)
        {
            x = player.GridPosition.X;
            y = player.GridPosition.Y;
        }

        /// <summary>
        /// Checks a 3x3 grid with from a startRow and startCols
        /// </summary>
        /// <param name="startRow"></param>
        /// <param name="startCol"></param>
        /// <returns> List of positionXY objects with GridPositions </returns>
        public static IEnumerable<PositionXY> FindOccupiedPositionsInRange(int startRow, int startCol)
        {
            var maxRow = PlayingField.Field.GetLength(0);
            var maxCol = PlayingField.Field.GetLength(1);


            var output = new List<PositionXY>();

            for (int row = Math.Max(startRow, 0); row < Math.Min(startRow + 3, maxRow); row++)
            {
                for (int col = Math.Max(startCol, 0); col < Math.Min(startCol + 3, maxCol); col++)
                {
                    if (PlayingField.Field[row, col])
                    {
                        output.Add(new PositionXY(row, col));
                    }
                }
            }

            return output;
        }
    }
}
