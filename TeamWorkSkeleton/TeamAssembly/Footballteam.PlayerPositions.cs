namespace TeamAssembly
{
    using Global.Contracts;
    using Global.DataStructures;
    using Global.Enumerations.Team;
    using Global.Enumerations.Utils;
    using Global.Settings.Visualization;

    public partial class FootballTeam
    {
        private static int gridRows;
        private static int gridCols;

        /// <summary>
        /// Assign each player a position on the PlayingField grid 
        /// and pixel position for Canvas drawing.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <param name="field"></param>
        public void GetInitialFootballPlayerPositions
            (int rows, int cols , StartingFieldType field)
        {
            gridRows = rows;
            gridCols = cols;

            var goalkeeperCol = 0;
            var defenderCol = 2;
            var midfielderCol = 4;
            var attackerCol = 6;

            if (field == StartingFieldType.Right)
            {
                goalkeeperCol = gridCols - 1;
                defenderCol = goalkeeperCol - 2;
                midfielderCol = defenderCol - 2;
                attackerCol = midfielderCol - 2;
            }

            var playerCounter = 0;

            var formationValues =
                ParseFormationType
                    .GetFormationValues(this.FormationType);

            // Goalkeeper Position.
            var row = gridRows / 2;

            this.Team[0].GridPosition = new PositionXY(row, goalkeeperCol);
            this.Team[0].FieldPosition =
                PlayingFieldSettings.GridCoordinates[
                    this.Team[0].GridPosition.X,
                    this.Team[0].GridPosition.Y];

            playerCounter++;

            // Defenders Positions.
            var numberOfDefenders = formationValues[0];
            playerCounter = FillPosition(this, playerCounter, numberOfDefenders, defenderCol);

            // Midfielders Positions.
            var numberOfMidfielders = formationValues[1];
            playerCounter = FillPosition(this, playerCounter, numberOfMidfielders, midfielderCol);

            // Attackers Positions.
            var numberOfAttackers = formationValues[2];
            playerCounter = FillPosition(this, playerCounter, numberOfAttackers, attackerCol);
        }

        private static int GetIncrement(int numberOfPlayers)
        {
            return PlayingFieldSettings.GridRows
                / (numberOfPlayers + 1);
        }

        private static int FillPosition(ITeam team, int playerCounter, int numberOfPlayers, int colConstant)
        {
            var rowIncrement = GetIncrement(numberOfPlayers);

            var row = rowIncrement;

            var len = playerCounter + numberOfPlayers;
            for (var i = playerCounter; i < len; i++)
            {
                team.Team[i].GridPosition =
                    new PositionXY(row, colConstant);

                team.Team[i].FieldPosition =
                    PlayingFieldSettings.GridCoordinates[
                        team.Team[i].GridPosition.X,
                        team.Team[i].GridPosition.Y];

                row += rowIncrement;
                playerCounter++;
            }

            return playerCounter;
        }
    }
}