namespace StartUpWPF
{
    using Game.PlayingField.Methods;
    using Game.Tracker;
    using Global.Settings.Visualization;
    using System;
    using System.Windows;
    using TeamWork.Models.PC.Reimplementation.Models;
    public partial class MainWindow
    {
        /// <summary>
        /// Roll against the enemy goalkeeper Save stat 
        /// to determine the outcome of the shot.
        /// Then adjust the appropriate GaemStateTracker props.
        /// Also adjust the visuals.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShootBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var shooter = GameStateTracker.FootballPlayerWithBall; //this.GetTargetPlayer(childIndex);
                                                                   // Find enemy players.
            var goalkeeper = GameStateTracker.GetOpponent().PlayerCharacter.Team.Team[0];

            bool isGoal = shooter.Shoot(goalkeeper);

            if (isGoal)
            {
                //Update Shooter's team score +=1
                //Update Teams initial player's positions
                //Update ball possession and visuals
                PlayingFieldMethods.UpdateAllPlayers(PlayerOne.Instance.PlayerCharacter.Team.Team);
                PlayingFieldMethods.UpdateAllPlayers(PlayerTwo.Instance.PlayerCharacter.Team.Team);
                GameStateTracker.FootballPlayerWithBall.HasBall = false;
                GameStateTracker.FootballPlayerWithBall = GameStateTracker.GetOpponent().PlayerCharacter.Team.Team[5];
                GameStateTracker.FootballPlayerWithBall.HasBall = true;
            }
            else
            {
                //Update ball possession and visuals

                GameStateTracker.FootballPlayerWithBall.HasBall = false;
                GameStateTracker.FootballPlayerWithBall = goalkeeper;
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
}
