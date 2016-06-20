using PlayerAssembly.HumanPlayerClass.PlayerOneSingletonClass;
using PlayerAssembly.HumanPlayerClass.PlayerTwoSingletonClass;

namespace PlayingFieldMethodsAssembly
{
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using PlayingFIeldAssembly;
    using TeamAssembly;

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

        private static void GetPlayerXY(FootballPlayer player, out int x, out int y)
        {
            x = player.GridPosition.X;
            y = player.GridPosition.Y;
        }
    }
}
