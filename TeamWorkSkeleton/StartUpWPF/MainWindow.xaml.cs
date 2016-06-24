namespace StartUpWPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;
    using Game.Logic;
    using Global.Contracts.PC;
    using Teamwork.Models.PC.Human.Singletons;
    using UI.Element.Manager.Contracts;
    using UI.Element.Manager.UIManager;

    /// <summary>
    /// App runs here.
    /// Call Methods elsewhere.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

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

            // Initialize players and their teams.
            InitialGameState.InitializePlayers();

            // Display players on the Field.
            InitialGameState.InitializeCanvas(this.PlayFieldCanvas);

            // Prep first turn.
            InitialGameState.InitializeFirstTurn(this.PlayFieldCanvas);

            // Display all 
            this.DisplayUI();

            // Subscribe to all FootballPlayer's events.
            this.SubscribeToFootballPlayerEvents();
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

            NextTurn.ChangeGameState(this.PlayFieldCanvas);

            this.DisplayUI();
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

            this.PlayFieldCanvas.Children.Clear();
            this.StartBtn.Visibility = Visibility.Visible;
            this.Buttons.Hide();
        }
    }
}
