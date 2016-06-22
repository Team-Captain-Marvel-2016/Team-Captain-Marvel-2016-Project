namespace Game.PlayingField.Methods
{
    using System;
    using System.Collections.Generic;
    using Game.PlayingField;
    using Global.DataStructures;
    using TeamAssembly;
    using Teamwork.Models.PC.Human.Singletons;
    using FootballPlayer = TeamWork.Models.Abstract.FootballPlayer;

    public static class PlayingFieldMethods
    {
        public static void MarkAllPlayersFromTeam(FootballTeam team)
        {
            foreach (var footballPlayer in team.Team)
            {
                int row, col;
                GetPlayerXY(footballPlayer, out row, out col);

                PlayingField.Field[row, col] = true;
            }
        }

        public static void UnMarkAllPlayersFromTeam(FootballTeam team)
        {
            foreach (var footballPlayer in team.Team)
            {
                int row, col;
                GetPlayerXY(footballPlayer, out row, out col);

                PlayingField.Field[row, col] = false;
            }
        }

        public static void MarkPlayerPosition(FootballPlayer player)
        {
            int row, col;
            GetPlayerXY(player, out row, out col);

            PlayingField.Field[row, col] = true;
        }

        public static void UnMarkPlayerPosition(FootballPlayer player)
        {
            int row, col;
            GetPlayerXY(player, out row, out col);

            PlayingField.Field[row, col] = false;
        }

        public static void TogglePlayerPosition(FootballPlayer player)
        {
            int row, col;
            GetPlayerXY(player, out row, out col);

            PlayingField.Field[row, col] = !PlayingField.Field[row, col];
        }

        public static void UpdateAllPlayers()
        {
            UnMarkAllPlayersFromTeam(PlayerOne.Player.Team);
            UnMarkAllPlayersFromTeam(PlayerTwo.Player.Team);

            MarkAllPlayersFromTeam(PlayerOne.Player.Team);
            MarkAllPlayersFromTeam(PlayerTwo.Player.Team);
        }

        public static void GetPlayerXY(FootballPlayer player, out int x, out int y)
        {
            x = player.GridPosition.X;
            y = player.GridPosition.Y;
        }

        public static IEnumerable<PositionXY> FindOccupiedPositionsInRange(int startRow, int startCol)
        {
            var maxRow = PlayingField.Field.GetLength(0);
            var maxCol = PlayingField.Field.GetLength(1);


            var output = new List<PositionXY>();

            for (int row = Math.Max(startRow, 0); row < Math.Min(startRow + 3, maxRow); row++)
            {
                for (int col = Math.Max(startCol, 0); col < Math.Min(startCol + 3, maxCol) ; col++)
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
