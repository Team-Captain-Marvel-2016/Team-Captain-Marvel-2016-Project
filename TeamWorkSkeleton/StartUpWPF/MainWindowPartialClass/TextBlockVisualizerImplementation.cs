namespace StartUpWPF
{
    using Game.Tracker;
    using TeamWork.Vsualizer.Text;

    public partial class MainWindow
    {
        /// <summary>
        /// Wrap the TextBlocks in their
        /// ITextVisualizer objects.
        /// </summary>
        private void InitializeTextBlockVisualizer()
        {
            this.TextBlockBottom = new TextBlockVisualizer(this.LogTextBlock);
            this.TextBlockBottom.Hide();
            
            this.TextBlockTop = new TextBlockVisualizer(this.InfoTextBlock);
            this.TextBlockTop.Hide();
        }

        /// <summary>
        /// Displays Score, Player on turn and turn number
        /// </summary>
        private void UpdateInfoText()
        {
            this.TextBlockTop.Display(
                string.Format(
                    "PlayerOne {0, 2} - {1, -2} PlayerTwo\t\t\tPlayer: {3} Turn: {2}",
                    GameStateTracker.PlayerOneScore,
                    GameStateTracker.PlayerTwoScore,
                    GameStateTracker.TurnNumber,
                    GameStateTracker.PlayerOnTurn.PlayerCharacter.Name));
        }

        /// <summary>
        /// Displays the name of the current football player
        /// and the remaining AP.
        /// </summary>
        private void UpdatePlayerText()
        {
            this.TextBlockBottom.Display(
                string.Format(
                    "Football Player: {0,-20}\t\t  Action Points: {1}",
                    GameStateTracker.SelectedFootballPlayer.Name,
                    GameStateTracker.SelectedFootballPlayer.CurrentAP));
        }
    }
}