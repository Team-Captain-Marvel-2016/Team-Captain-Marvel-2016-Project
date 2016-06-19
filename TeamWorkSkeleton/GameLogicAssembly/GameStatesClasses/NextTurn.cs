namespace GameLogicAssembly.GameStatesClasses
{
    using PlayerAssembly.AbstractPlayerClass;
    using PlayerAssembly.HumanPlayerClass.PlayerOneSingletonClass;
    using PlayerAssembly.HumanPlayerClass.PlayerTwoSingletonClass;
    using System.Windows.Controls;
    using VisualizationAssembly.CanvasUtilsClasses;

    public static class NextTurn
    {
        public static bool IncrementTurn()
        {
            if (GameStateTrackers.TurnNumber == GameStateTrackers.GameLengthTurns)
            {
                return false;
            }

            GameStateTrackers.TurnNumber++;

            return true;
        }

        public static void ChangeGameState(Canvas canvas)
        {
            // Reset marked FootballPlayer and Increment PC current player.
            GameStateTrackers.PlayerOnTurn.ResetVisualTokenSize();
            GameStateTrackers.PlayerOnTurn.NextPlayer();

            // GetNext PlayerCharacter
            GameStateTrackers.PlayerOnTurn = GetNextPlayer();

            // GetNext Football Player
            GameStateTrackers.SelectedFootballPlayer =
                GameStateTrackers.PlayerOnTurn.Team.Team[
                    GameStateTrackers.PlayerOnTurn.CurrentPlayer];

            CanvasChildrenUtilities.MarkCurrentPlayer
                (canvas, GameStateTrackers.SelectedFootballPlayer);
        }

        private static PlayerCharacter GetNextPlayer()
        {
            return GameStateTrackers.PlayerOnTurn.GetType() == PlayerOne.Player.GetType() ?
                   (PlayerCharacter)PlayerTwo.Player : (PlayerCharacter)PlayerOne.Player;
        }
    }
}
