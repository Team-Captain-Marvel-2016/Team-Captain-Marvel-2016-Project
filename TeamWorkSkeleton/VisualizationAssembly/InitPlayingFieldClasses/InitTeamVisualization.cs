
namespace VisualizationAssembly.InitPlayingFieldClasses
{
    using Enumerations;
    using GlobalSettingsAssembly.VisualizationSettings;
    using GlobalDataStructures;
    using TeamAssembly;
    using TeamAssembly.FormationTypeParsingMethods;


    public static class InitTeamVisualization
    {
        public static void GetInitialFootballPlayerPositions
            (FootballTeam team, StartingFieldType field)
        {
            #region // Column Indexes
            var goalkeeperCol = 0;
            var defenderCol = 2;
            var midfielderCol = 4;
            var attackerCol = 6;

            if (field == StartingFieldType.Right)
            {
                goalkeeperCol = PlayingFieldVisualizationSettings.GridCols - 1;
                defenderCol = goalkeeperCol - 2;
                midfielderCol = defenderCol - 2;
                attackerCol = midfielderCol - 2;
            }
            #endregion

            var playerCounter = 0;

            var formationValues =
                ParseFormationType
                    .GetFormationValues(team.Formation);

            // Goalkeeper Position.
            var row = PlayingFieldVisualizationSettings.GridRows / 2;

            team.Team[0].GridPosition = new PositionXY(row, goalkeeperCol);
            team.Team[0].FieldPosition =
                PlayingFieldVisualizationSettings.GridCoordinates[
                    team.Team[0].GridPosition.X,
                    team.Team[0].GridPosition.Y];

            playerCounter++;

            // Defenders Positions.
            var numberOfDefenders = formationValues[0];
            playerCounter = FillPosition(team, playerCounter, numberOfDefenders, defenderCol);

            // Midfielders Positions.
            var numberOfMidfielders = formationValues[1];
            playerCounter = FillPosition(team, playerCounter, numberOfMidfielders, midfielderCol);

            // Attackers Positions.
            var numberOfAttackers = formationValues[2];
            playerCounter = FillPosition(team, playerCounter, numberOfAttackers, attackerCol);
        }

        private static int GetIncrement(int numberOfPlayers)
        {
            return PlayingFieldVisualizationSettings.GridRows
                / (numberOfPlayers + 1);
        }

        private static int FillPosition(FootballTeam team, int playerCounter, int numberOfPlayers, int colConstant)
        {
            var rowIncrement = GetIncrement(numberOfPlayers);

            var row = rowIncrement;

            var len = playerCounter + numberOfPlayers;
            for (var i = playerCounter; i < len; i++)
            {
                team.Team[i].GridPosition = new PositionXY(row, colConstant);
                team.Team[i].FieldPosition =
                    PlayingFieldVisualizationSettings.GridCoordinates[
                        team.Team[i].GridPosition.X,
                        team.Team[i].GridPosition.Y];

                row += rowIncrement;
                playerCounter++;
            }

            return playerCounter;
        }
    }
}
