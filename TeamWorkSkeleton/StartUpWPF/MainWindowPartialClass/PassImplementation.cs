namespace StartUpWPF
{
    using Game.Tracker;
    using Global.Contracts;
    using System;
    using System.Windows;
    using System.Windows.Shapes;
    using Global.Settings.Visualization;

    public partial class MainWindow
    {
        private delegate void OnMouseDownAdd(object sender, EventArgs args);

        /// <summary>
        /// Add an OnMouseDown event to the VisualTokens
        /// of all friendly targets.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PassBtn_OnClick(object sender, RoutedEventArgs e)
        {
            // Select Target.
            // Add MouseDownEvents to All Players.
            // On click -> remove those events.
            this.AddMouseDownEventPass();
        }

        /// <summary>
        /// object sender is the VisualToken of the target player.
        /// Identify the football player object through it's 
        /// visual token.
        /// Check for enemey players which can affect the pass.
        /// Calculate the action for each enemy in range.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnMouseDownPass(object sender, EventArgs args)
        {
            // Remove Event.
            this.RemoveMouseDownEventPass();

            // Find the target player by CanvasChildIndex based on the sender object.
            var childIndex = this.PlayFieldCanvas.Children.IndexOf((Ellipse)sender);
            var target = this.GetTargetPlayer(childIndex);

            // Find enemy players.
            var listOfEnemyPlayers = this.GetEnemyPlayers(target);

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
        
        /// <summary>
        /// Transfer the "ball" to the target player.
        /// Adjust GameStateTracker props
        /// Adjust Visuals
        /// </summary>
        /// <param name="targetFootballPlayer"></param>
        private void UpdateGameStateOnSuccessfulPass(IFootballPlayer targetFootballPlayer)
        {
            GameStateTracker.FootballPlayerWithBall.HasBall = false;
            GameStateTracker.FootballPlayerWithBall = targetFootballPlayer;
            GameStateTracker.FootballPlayerWithBall.HasBall = true;

            GameStateTracker.PlayerOnTurn.PlayerCharacter.ResetVisualTokenColor();
            this.GameGraphics.SetTokenColor(
                GameStateTracker.FootballPlayerWithBall,
                FootballPlayerSettings.BallColor);

            this.DisplayUIZeroAP?.Invoke(this, null);
        }

        /// <summary>
        /// Transfer the ball to the intercepting enemy player.
        /// Adjust GameStateTracker props
        /// Adjust visuals.
        /// </summary>
        /// <param name="enemyPlayer"></param>
        private void UpdateGameStateOnUnsuccessfulPass(IFootballPlayer enemyPlayer)
        {
            GameStateTracker.FootballPlayerWithBall.HasBall = false;
            GameStateTracker.FootballPlayerWithBall = enemyPlayer;
            GameStateTracker.FootballPlayerWithBall.HasBall = true;

            GameStateTracker.PlayerOnTurn.PlayerCharacter.ResetVisualTokenColor();
            this.GameGraphics.SetTokenColor(
                GameStateTracker.FootballPlayerWithBall,
                FootballPlayerSettings.BallColor);

            GameStateTracker.PlayerOnTurn.PlayerCharacter.Team.HasBallPossession = false;
            GameStateTracker.GetOpponent().PlayerCharacter.Team.HasBallPossession = true;
            GameStateTracker.PlayerWihBall = GameStateTracker.GetOpponent();

            this.DisplayUIZeroAP?.Invoke(this, null);
        }
    }
}
