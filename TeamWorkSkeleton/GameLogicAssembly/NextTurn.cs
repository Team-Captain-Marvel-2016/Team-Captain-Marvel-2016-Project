namespace Game.Logic
{
    using System.Windows.Controls;
    using Teamwork.Models.PC.Abstract;
    using Teamwork.Models.PC.Human.Singletons;
    using Tracker;
    using Visualization;

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

        public static void ChangeGameState(Canvas canvas)
        {
            // Reset current FootballPlayer AP
            GameStateTracker.SelectedFootballPlayer.ResetActionPoints();

            // Reset marked FootballPlayer and Increment PC current player.
            GameStateTracker.PlayerOnTurn.ResetVisualTokenSize();
            GameStateTracker.PlayerOnTurn.NextPlayer();

            // GetNext PlayerCharacter
            GameStateTracker.PlayerOnTurn = GetNextPlayer();

            // GetNext Football Player
            GameStateTracker.SelectedFootballPlayer =
                GameStateTracker.PlayerOnTurn.Team.Team[
                    GameStateTracker.PlayerOnTurn.CurrentPlayer];

            CanvasChildrenUtilities.MarkCurrentPlayer
                (canvas, GameStateTracker.SelectedFootballPlayer);
        }

        private static PlayerCharacter GetNextPlayer()
        {
            return GameStateTracker.PlayerOnTurn.GetType() == PlayerOne.Player.GetType() ?
                   (PlayerCharacter)PlayerTwo.Player : (PlayerCharacter)PlayerOne.Player;
        }
    }
}
