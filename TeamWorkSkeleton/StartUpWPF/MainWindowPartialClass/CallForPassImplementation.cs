namespace StartUpWPF
{
    using Game.Tracker;
    using Global.Contracts;
    using System.Windows;

    public partial class MainWindow
    {
        /// <summary>
        /// Button is active if another FootballPlayer on the same team
        /// is marked as havingball possession.
        /// This reuses the Pass implementation with the target
        /// being the FootballPlayer calling for the pass.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CallForPassBtn_OnClick(object sender, RoutedEventArgs e)
        {
            // target is player with ball
            var target = GameStateTracker.FootballPlayerWithBall;

            // Find enemy players.
            var listOfEnemyPlayers = this.GetEnemyPlayers(target);

            // If there are no enemies then pass is successfull
            if (listOfEnemyPlayers.Count == 0)
                this.UpdateGameStateOnSuccessfulPass(
                    GameStateTracker.SelectedFootballPlayer);

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
                this.UpdateGameStateOnSuccessfulPass(GameStateTracker.SelectedFootballPlayer);
            }
            else
            {
                this.UpdateGameStateOnUnsuccessfulPass(interceptintPlayer);
            }
        }
    }
}
