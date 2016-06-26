namespace StartUpWPF
{
    using System.Collections.Generic;
    using Game.PlayingField.Methods;
    using Game.Tracker;
    using Global.Contracts;

    public partial class MainWindow
    {
        /// <summary>
        /// Gets a list of coordinates with objects from PlayingField grid.
        /// Filters those objects to ones which on the enemy players team.
        /// </summary>
        /// <param name="target"></param>
        /// <returns>List of enemy players to roll against.</returns>
        private List<IFootballPlayer> GetEnemyPlayers(IFootballPlayer target)
        {
            // Find enemy players.
            var coordinatesWithObjects =
                GridPositionUtils
                    .FindObjectsInRange(GameStateTracker.SelectedFootballPlayer, target);

            var opponent = GameStateTracker.GetOpponent();

            var listOfEnemyPlayers =
                opponent.PlayerCharacter.GetPlayersOnPositionsList(coordinatesWithObjects);

            return listOfEnemyPlayers;
        }

        /// <summary>
        /// Searches for enemy players in adjoining grid cells.
        /// </summary>
        /// <param name="startRow"></param>
        /// <param name="startCol"></param>
        /// <returns></returns>
        private bool GetEnemeiesForTackle(int startRow, int startCol)
        {
            var coordinatesWithObjects = PlayingFieldMethods.FindOccupiedPositionsInRange(startRow, startCol);

            var opponent = GameStateTracker.GetOpponent();

            var listOfEnemyPlayers =
                opponent.PlayerCharacter.GetPlayersOnPositionsList(coordinatesWithObjects);

            foreach (var player in listOfEnemyPlayers)
            {
                if (player.HasBall)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
