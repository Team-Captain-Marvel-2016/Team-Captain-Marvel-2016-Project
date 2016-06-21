namespace StartUpWPF
{
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using GameStateTrackerAssembly;
    using System;
    using System.Windows;
    using System.Windows.Shapes;
    using GameLogicAssembly.GridPositionMethods;
    using PlayerAssembly.HumanPlayerClass.PlayerOneSingletonClass;
    using PlayerAssembly.HumanPlayerClass.PlayerTwoSingletonClass;
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

        private void CallForPassBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
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
            
            var opponent = GameStateTracker.PlayerOnTurn is PlayerOne
                ? PlayerTwo.Player
                : PlayerOne.Player;

            var listOfEnemyPlayers = 
                opponent.GetPlayersOnPositionsList(coordinatesWithObjects);
            
            // If there are no enemies than pass is successfull
            if (listOfEnemyPlayers.Count == 0) this.UpdateGameStateOnSuccessfullPass(target);

            // If there are enemies then evaluate each possible interception
            // Roll Dice / Do calculation.

            // Transfer the ball to friendly/ enemy.

            // Update visualization.

            // Update Game State.

            //throw new NotImplementedException();
        }

        private void UpdateGameStateOnSuccessfullPass(FootballPlayer targetFootballPlayer)
        {
            GameStateTracker.FootballPlayerWithBall.HasBall = false;
            GameStateTracker.FootballPlayerWithBall = targetFootballPlayer;
            GameStateTracker.FootballPlayerWithBall.HasBall = true;
            
            GameStateTracker.PlayerOnTurn.ResetVisualTokenColor();
            CanvasChildrenUtilities.MarkPlayerWithBall(
                this.PlayFieldCanvas,
                GameStateTracker.FootballPlayerWithBall);
        }

        private void TackleBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnMouseDownTackle(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }

        private void ShootBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private FootballPlayer GetTargetPlayer(int index)
        {
            foreach (var footballPlayer in GameStateTracker.PlayerOnTurn.Team.Team)
            {
                if (footballPlayer.CanvasChildIndex == index)
                {
                    return footballPlayer;
                }
            }

            throw new Exception("Target not found");
        }
    }
}
