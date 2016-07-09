namespace StartUpWPF
{
    using Game.Tracker;
    using Global.Contracts;
    using Global.Settings.Visualization;
    using System.Windows;

    public partial class MainWindow
    {

        /// <summary>
        /// Use GameStateTracker.footballplayerwithball
        /// roll the tackle prop of this player 
        /// against the dribble of the player with ball.
        /// Adjust the GameStateTracker and Visuals based on outcome.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TackleBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var isSuccessfulTackle = GameStateTracker.SelectedFootballPlayer.Tackle(GameStateTracker.FootballPlayerWithBall);

            if (isSuccessfulTackle)
            {
                this.UpdateGameStateOnSuccessfulTackle(GameStateTracker.SelectedFootballPlayer);
            }
            else
            {
                this.DisplayUIZeroAP?.Invoke(this, null);
            }
        }

        /// <summary>
        /// Change possession to the successful tackler
        /// </summary>
        /// <param name="tacklingPlayer"></param>
        private void UpdateGameStateOnSuccessfulTackle(IFootballPlayer tacklingPlayer)
        {
            GameStateTracker.FootballPlayerWithBall.HasBall = false;
            GameStateTracker.FootballPlayerWithBall = tacklingPlayer;
            GameStateTracker.FootballPlayerWithBall.HasBall = true;

            GameStateTracker.GetOpponent().PlayerCharacter.ResetVisualTokenColor();
            GameStateTracker.PlayerOnTurn.PlayerCharacter.ResetVisualTokenColor();
            this.GameGraphics.SetTokenColor(
                GameStateTracker.FootballPlayerWithBall,
                FootballPlayerSettings.BallColor);

            GameStateTracker.PlayerOnTurn.PlayerCharacter.Team.HasBallPossession = true;
            GameStateTracker.GetOpponent().PlayerCharacter.Team.HasBallPossession = false;
            GameStateTracker.PlayerWihBall = GameStateTracker.GetOpponent();

            this.DisplayUIZeroAP?.Invoke(this, null);
        }
    }
}