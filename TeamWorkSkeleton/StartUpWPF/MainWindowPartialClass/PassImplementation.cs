namespace StartUpWPF
{
    using Game.PlayingField.Methods;
    using Game.Tracker;
    using Global.Contracts;
    using System;
    using System.Windows;
    using System.Windows.Shapes;
    using VisualizationAssembly.CanvasUtilsClasses;

    public partial class MainWindow
    {
        private delegate void OnMouseDownAdd(object sender, EventArgs args);

        private void PassBtn_OnClick(object sender, RoutedEventArgs e)
        {
            // Select Target.
            // Add MouseDownEvents to All Players.
            // On click -> remove those events.
            this.AddMouseDownEventPass();
        }

        private void OnMouseDownPass(object sender, EventArgs args)
        {
            // Remove Event.
            this.RemoveMouseDownEventPass();

            // Find the target player by CanvasChildIndex based on the sender object.
            var childIndex = this.PlayFieldCanvas.Children.IndexOf((Ellipse)sender);
            var target = this.GetTargetPlayer(childIndex);

            // Find enemy players.
            var coordinatesWithObjects =
                GridPositionUtils.FindObjectsInRange(GameStateTracker.SelectedFootballPlayer, target);

            var opponent = GameStateTracker.GetOpponent();

            var listOfEnemyPlayers =
                opponent.PlayerCharacter.GetPlayersOnPositionsList(coordinatesWithObjects);

            // If there are no enemies then pass is successfull
            if (listOfEnemyPlayers.Count == 0) this.UpdateGameStateOnSuccessfulPass(target);

            // If there are enemies then evaluate each possible interception
            IFootballPlayer interceptintPlayer = null;
            foreach (var enemyPlayer in listOfEnemyPlayers)
            {
                if (!GameStateTracker.SelectedFootballPlayer.Pass(enemyPlayer))
                {
                    interceptintPlayer = enemyPlayer;
                    break;
                }
            }

            if (interceptintPlayer == null)
            {
                this.UpdateGameStateOnSuccessfulPass(target);
            }
            else
            {
                this.UpdateGameStateOnUnsuccessfulPass(interceptintPlayer);
            }
        }

        private void UpdateGameStateOnSuccessfulPass(IFootballPlayer targetFootballPlayer)
        {
            GameStateTracker.FootballPlayerWithBall.HasBall = false;
            GameStateTracker.FootballPlayerWithBall = targetFootballPlayer;
            GameStateTracker.FootballPlayerWithBall.HasBall = true;

            GameStateTracker.PlayerOnTurn.PlayerCharacter.ResetVisualTokenColor();
            CanvasChildrenUtilities.MarkPlayerWithBall(
                this.PlayFieldCanvas,
                GameStateTracker.FootballPlayerWithBall);

            this.DisplayUIZeroAP?.Invoke(this, null);
        }

        private void UpdateGameStateOnUnsuccessfulPass(IFootballPlayer enemyPlayer)
        {
            GameStateTracker.FootballPlayerWithBall.HasBall = false;
            GameStateTracker.FootballPlayerWithBall = enemyPlayer;
            GameStateTracker.FootballPlayerWithBall.HasBall = true;

            GameStateTracker.PlayerOnTurn.PlayerCharacter.ResetVisualTokenColor();
            CanvasChildrenUtilities.MarkPlayerWithBall(
                this.PlayFieldCanvas,
                GameStateTracker.FootballPlayerWithBall);

            GameStateTracker.PlayerOnTurn.PlayerCharacter.Team.HasBallPossession = false;
            GameStateTracker.GetOpponent().PlayerCharacter.Team.HasBallPossession = true;
            GameStateTracker.PlayerWihBall = GameStateTracker.GetOpponent();

            this.DisplayUIZeroAP?.Invoke(this, null);
        }
    }
}
