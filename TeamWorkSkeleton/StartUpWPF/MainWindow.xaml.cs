using GameStateTrackerAssembly;
using VisualizationAssembly.CanvasUtilsClasses;

namespace StartUpWPF
{
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

        private void MoveUpBtn_OnClick(object sender, RoutedEventArgs e)
        {
            // Move Player On the Grid
            try
            {
                GameStateTracker.SelectedFootballPlayer.MoveUp();
            }
            catch (Exception)
            {
                // TODO: Communicate Position was not free
                return;
            }

            // Update Canvas Position
            CanvasChildrenUtilities
                .UpdateCanvasPosition(PlayFieldCanvas, GameStateTracker.SelectedFootballPlayer);
        }

        private void MoveDownBtn_OnClick(object sender, RoutedEventArgs e)
        {
            // Move Player On the Grid
            try
            {
                GameStateTracker.SelectedFootballPlayer.MoveDown();
            }
            catch (Exception)
            {
                // TODO: Communicate Position was not free
                return;
            }

            // Update Canvas Position
            CanvasChildrenUtilities
                .UpdateCanvasPosition(PlayFieldCanvas, GameStateTracker.SelectedFootballPlayer);
        }

        private void MoveLeftBtn_OnClick(object sender, RoutedEventArgs e)
        {
            // Move Player On the Grid
            try
            {
                GameStateTracker.SelectedFootballPlayer.MoveLeft();
            }
            catch (Exception)
            {
                // TODO: Communicate Position was not free
                return;
            }

            // Update Canvas Position
            CanvasChildrenUtilities
                .UpdateCanvasPosition(PlayFieldCanvas, GameStateTracker.SelectedFootballPlayer);
        }

        private void MoveRightBtn_OnClick(object sender, RoutedEventArgs e)
        {
            // Move Player On the Grid
            try
            {
                GameStateTracker.SelectedFootballPlayer.MoveRight();
            }
            catch (Exception)
            {
                // TODO: Communicate Position was not free
                return;
            }

            // Update Canvas Position
            CanvasChildrenUtilities
                .UpdateCanvasPosition(PlayFieldCanvas, GameStateTracker.SelectedFootballPlayer);
        }

        /// <summary>
        /// Group buttons in groups for ease of access.
        /// </summary>
        private void InitializeButtonLists()
        {
            //// Buttons: Prev, Next
            SelectionButtons = new List<Button>();
            //SelectionButtons.Add(PrevPlayerBtn);
            //SelectionButtons.Add(NextPlayerBtn);

            // Buttons: Up, Down, Left, Right
            MovementButtons = new List<Button>();
            MovementButtons.Add(MoveUpBtn);
            MovementButtons.Add(MoveDownBtn);
            MovementButtons.Add(MoveLeftBtn);
            MovementButtons.Add(MoveRightBtn);

            // Buttons: Pass, Shoot
            BallActionButtons = new List<Button>();
            BallActionButtons.Add(PassBtn);
            BallActionButtons.Add(ShootBtn);

            // TODO: Create offense without ball button
            // TODO: Create defense tackle button
            // Button: Call For Pass
            NoBallButtons = new List<Button>();
            NoBallButtons.Add(CallForPassBtn);

            // Buttons: Tackle
            DefenseButtons = new List<Button>();
            DefenseButtons.Add(TackleBtn);

            // Buttons: End Turn
            EndTurnButtons = new List<Button>();
            EndTurnButtons.Add(EndTurnBtn);
            EndTurnButtons.Add(ResetBtn);

            // TODO: Add the remaining two lists
            // All Buttons
            AllButtons = new List<List<Button>>();
            AllButtons.Add(SelectionButtons);
            AllButtons.Add(MovementButtons);
            AllButtons.Add(BallActionButtons);
            AllButtons.Add(NoBallButtons);
            AllButtons.Add(DefenseButtons);
            AllButtons.Add(EndTurnButtons);
        }

        /// <summary>
        /// Display appropriate Button group.
        /// </summary>
        private void DisplayControlButtons()
        {
            // Hide all 
            AllButtons.DisableAll();

            //// Always display Movement and End Turn
            //MovementButtons.DisplayButtons();
            //EndTurnButtons.DisplayButtons();

            MovementButtons.EnableButtons();
            EndTurnButtons.EnableButtons();

            // Pick Action Button group
            var buttonGroup = FootballPlayerControls.GetButtonGroupToDisplay();
            AllButtons[buttonGroup].EnableButtons();
        }
    }
}
