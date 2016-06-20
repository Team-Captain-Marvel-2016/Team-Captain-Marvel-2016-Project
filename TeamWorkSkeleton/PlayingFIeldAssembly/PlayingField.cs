namespace PlayingFIeldAssembly
{
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using GameLogicEventsAssembly;
    using System;
    using TeamAssembly;

    public class PlayingField
    {
        public PlayingField(int x, int y)
        {
            this.Field = new bool[x, y];

            ResetGameState.ResetGameEvent += OnResetEvent;
        }

        public bool[,] Field { get; set; }

        public void MarkAllPlayersFromTeam(FootballTeam team)
        {
            foreach (var footballPlayer in team.Team)
            {
                int row, col;
                GetPlayerXY(footballPlayer, out row, out col);

                this.Field[row, col] = true;
            }
        }

        public void UnMarkAllPlayersFromTeam(FootballTeam team)
        {
            foreach (var footballPlayer in team.Team)
            {
                int row, col;
                GetPlayerXY(footballPlayer, out row, out col);

                this.Field[row, col] = false;
            }
        }

        public void MarkPlayerPosition(FootballPlayer player)
        {
            int row, col;
            GetPlayerXY(player, out row, out col);

            this.Field[row, col] = true;
        }

        public void UnMarkPlayerPosition(FootballPlayer player)
        {
            int row, col;
            GetPlayerXY(player, out row, out col);

            this.Field[row, col] = false;
        }

        public void TogglePlayerPosition(FootballPlayer player)
        {
            int row, col;
            GetPlayerXY(player, out row, out col);

            this.Field[row, col] = !this.Field[row, col];
        }

        private void GetPlayerXY(FootballPlayer player, out int x, out int y)
        {
            x = player.GridPosition.X;
            y = player.GridPosition.Y;
        }

        private void OnResetEvent(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
