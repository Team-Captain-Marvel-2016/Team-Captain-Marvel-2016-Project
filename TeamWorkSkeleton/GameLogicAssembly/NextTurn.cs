namespace Game.Logic
{
    using Global.Settings.Visualization;
    using TeamWork.Football.Visualizer.Contracts;
    using TeamWork.Models.PC.Reimplementation.Contracts;
    using Tracker;

    /// <summary>
    /// Used when the NextTurnBtn is clicked
    /// </summary>
    public static class NextTurn
    {
        /// <summary>
        /// Increment the GameStateTracker Turn counter.
        /// Game Over if the turn limit is reached.
        /// </summary>
        /// <returns></returns>
        public static bool IncrementTurn()
        {
            if (GameStateTracker.TurnNumber == GameStateTracker.GameLengthTurns)
            {
                return false;
            }

            GameStateTracker.TurnNumber++;

            return true;
        }

        /// <summary>
        /// Reassign all GameStateTracker props to reflect
        /// which FootballPlayer is beingcontrolled.
        /// Adjust visualization accordingly.
        /// </summary>
        /// <param name="visualizer"></param>
        public static void ChangeGameState(IVisualizer visualizer)
        {
            // Reset current FootballPlayer AP
            GameStateTracker.SelectedFootballPlayer.ResetActionPoints();

            // Reset marked FootballPlayer and Increment PC current player.
            GameStateTracker.PlayerOnTurn.PlayerCharacter.ResetVisualTokenSize();
            GameStateTracker.PlayerOnTurn.PlayerCharacter.NextPlayer();

            // GetNext PlayerCharacter
            GameStateTracker.PlayerOnTurn = GetNextPlayer();

            // GetNext Football Player
            GameStateTracker.SelectedFootballPlayer =
                GameStateTracker.PlayerOnTurn.PlayerCharacter.Team.Team[
                    GameStateTracker.PlayerOnTurn.PlayerCharacter.CurrentPlayer];

            visualizer.SetTokenSize(
                GameStateTracker.SelectedFootballPlayer,
                FootballPlayerSettings.SelectedVisualTokenSize,
                FootballPlayerSettings.SelectedVisualTokenSize);
        }

        /// <summary>
        /// Return the IPlayer character which is NOT the 
        /// current IPlayer on turn.
        /// </summary>
        /// <returns></returns>
        private static IPlayer GetNextPlayer()
        {
            return GameStateTracker.GetOpponent();    
        }
    }
}
