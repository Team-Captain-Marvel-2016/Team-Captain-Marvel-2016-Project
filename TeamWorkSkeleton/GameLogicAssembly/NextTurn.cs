namespace Game.Logic
{
    using Global.Settings.Visualization;
    using TeamWork.Football.Visualizer.Contracts;
    using TeamWork.Models.PC.Reimplementation.Contracts;
    using Tracker;

    public static class NextTurn
    {
        public static bool IncrementTurn()
        {
            if (GameStateTracker.TurnNumber == GameStateTracker.GameLengthTurns)
            {
                return false;
            }

            GameStateTracker.TurnNumber++;

            return true;
        }

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

        private static IPlayer GetNextPlayer()
        {
            return GameStateTracker.GetOpponent();    
        }
    }
}
