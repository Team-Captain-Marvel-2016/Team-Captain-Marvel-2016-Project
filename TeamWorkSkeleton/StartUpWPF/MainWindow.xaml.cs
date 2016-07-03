namespace StartUpWPF
{
    using Game.Logic;
    using Global.Settings.Visualization;
    using System.Windows;
    using TeamWork.Football.Visualizer;
    using TeamWork.Vsualizer.Text;

    /// <summary>
    /// App runs here.
    /// Call Methods elsewhere.
    /// </summary>
    public partial class MainWindow : Window
    {
        internal Graphics GameGraphics { get; private set; }
        internal TextBlockVisualizer TextBlockBottom { get; private set; }
        internal TextBlockVisualizer TextBlockTop { get; private set; }

        public MainWindow()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.InitializeComponent();

            this.ScrollViewerBot.Visibility = Visibility.Collapsed;
            this.ScrollViewerTop.Visibility = Visibility.Collapsed;

            this.InitializeTextBlockVisualizer();

            this.InitializeButtonManager();
            this.Buttons.Hide();
        }

        /// <summary>
        /// Hide Start Game button.
        /// Create PlayerOne and PlayerTwo
        /// and their teams of FootballPlayer objects
        /// Display all VisualTokens on the PLayFieldCanvas.
        /// Display all buttons and enable the appropriate ones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            // Hide The Start Button
            this.StartBtn.Visibility = Visibility.Collapsed;

            this.ScrollViewerBot.Visibility = Visibility.Visible;
            this.ScrollViewerTop.Visibility = Visibility.Visible;

            this.TextBlockTop.Show();
            this.TextBlockBottom.Show();

            // Initialize players and their teams.
            InitialGameState.InitializePlayers();

            // Display players on the Field.
            var width = PlayingFieldSettings.Width;
            var height = PlayingFieldSettings.Height;
            this.GameGraphics = new Graphics(this.PlayFieldCanvas, width, height);

            InitialGameState.InitializeVisualizer(this.GameGraphics);

            InitialGameState.InitializeFirstTurn(this.GameGraphics);

            // Display all 
            this.DisplayUI();

            // Subscribe to all FootballPlayer's events.
            this.SubscribeToFootballPlayerEvents();

            // Update Top TextBlock
            this.UpdateInfoText();
            this.UpdatePlayerText();

        }

        /// <summary>
        /// Increment game turn number. 
        /// Game Over if limit is reached.
        /// Update GameStateTracker.
        /// Enable appropriate buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndTurnBtn_Click(object sender, RoutedEventArgs e)
        {
            // Increment Turn.
            if (!NextTurn.IncrementTurn())
            {
                GameOver.ResetGameState();
            }

            NextTurn.ChangeGameState(this.GameGraphics);

            this.DisplayUI();

            this.UpdateInfoText();
            this.UpdatePlayerText();
        }

        /// <summary>
        /// Reset App state to initial state.
        /// Remove Players. 
        /// Reset Trackers
        /// Hide gameplay UI.
        /// Display Start Game button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetBtn_OnClick_Click(object sender, RoutedEventArgs e)
        {
            ResetGameMethods.ResetGame();

            this.GameGraphics.Reset();
            
            this.StartBtn.Visibility = Visibility.Visible;
            this.Buttons.Hide();

            this.ScrollViewerBot.Visibility = Visibility.Collapsed;
            this.ScrollViewerTop.Visibility = Visibility.Collapsed;

            this.TextBlockTop.Clear();
            this.TextBlockBottom.Clear();
        }
    }
}
