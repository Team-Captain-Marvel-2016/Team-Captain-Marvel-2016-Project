namespace StartUpWPF
{
    using System.Windows.Controls;
    using Game.Tracker;
    using TeamWork.Vsualizer.Text;

    public partial class MainWindow
    {
        private void InitializeTextBlockVisualizer()
        {
            this.TextBlockBottom = new TextBlockVisualizer(this.LogTextBlock);
            this.TextBlockBottom.Hide();
            
            this.TextBlockTop = new TextBlockVisualizer(this.InfoTextBlock);
            this.TextBlockTop.Hide();
        }

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
    }
}