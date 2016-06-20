namespace StartUpWPF
{
    using GameStateTrackerAssembly;
    using PlayingFieldMethodsAssembly;
    using VisualizationAssembly.CanvasUtilsClasses;
    using GameLogicAssembly.GameControlsClasses;
    using GameLogicAssembly.GameStatesClasses;
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
    using UserInterfaceAssembly.UserControlsClasses;

    /// <summary>
    /// App runs here.
    /// Call Methods elsewhere.
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Button groups
        internal List<List<Button>> AllButtons;
        internal List<Button> SelectionButtons;
        internal List<Button> MovementButtons;
        internal List<Button> BallActionButtons;
        internal List<Button> NoBallButtons;
        internal List<Button> DefenseButtons;
        internal List<Button> EndTurnButtons;
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            InitializeButtonLists();
            AllButtons.CollapseAll();
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
            StartBtn.Visibility = Visibility.Collapsed;

            // Initialize players and their teams.
            InitialGameState.InitializePlayers();

            // Display players on the Field.
            InitialGameState.InitializeCanvas(PlayFieldCanvas);

            // Prep first turn.
            InitialGameState.InitializeFirstTurn(PlayFieldCanvas);

            // Display all 
            AllButtons.DisplayAll();

            // Enable Appropriate Buttons
            DisplayControlButtons();

            // Subscribe to all FootballPlayer's events.
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

            NextTurn.ChangeGameState(PlayFieldCanvas);

            DisplayControlButtons();
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

            PlayFieldCanvas.Children.Clear();
            AllButtons.CollapseAll();
            StartBtn.Visibility = Visibility.Visible;
        }

        private void OnZeroActionPoints(object sender, EventArgs args)
        {
            
        }
    }
}
