namespace StartUpWPF
{
    using System;
    using System.Windows;
    using System.Windows.Shapes;
    using Game.PlayingField.Methods;
    using Game.Tracker;
    using Global.Contracts;
    using VisualizationAssembly.CanvasUtilsClasses;
    using FootballPlayer = TeamWork.Models.Abstract.FootballPlayer;

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
                opponent.GetPlayersOnPositionsList(coordinatesWithObjects);

            // If there are no enemies then pass is successfull
            if (listOfEnemyPlayers.Count == 0) this.UpdateGameStateOnSuccessfulPass(target);

            // If there are enemies then evaluate each possible interception
            FootballPlayer interceptintPlayer = null;
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

            GameStateTracker.PlayerOnTurn.ResetVisualTokenColor();
            CanvasChildrenUtilities.MarkPlayerWithBall(
                this.PlayFieldCanvas,
                GameStateTracker.FootballPlayerWithBall);
        }

        private void UpdateGameStateOnUnsuccessfulPass(IFootballPlayer enemyPlayer)
        {
            GameStateTracker.FootballPlayerWithBall.HasBall = false;
            GameStateTracker.FootballPlayerWithBall = enemyPlayer;
            GameStateTracker.FootballPlayerWithBall.HasBall = true;

            GameStateTracker.PlayerOnTurn.ResetVisualTokenColor();
            CanvasChildrenUtilities.MarkPlayerWithBall(
                this.PlayFieldCanvas,
                GameStateTracker.FootballPlayerWithBall);

            GameStateTracker.PlayerOnTurn.Team.HasBall = false;
            GameStateTracker.GetOpponent().Team.HasBall = true;
            GameStateTracker.PlayerWihBall = GameStateTracker.GetOpponent();
        }
    }
}
