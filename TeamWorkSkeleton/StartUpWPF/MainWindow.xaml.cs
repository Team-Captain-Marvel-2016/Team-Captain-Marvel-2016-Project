namespace StartUpWPF
{
    using GameLogicAssembly.GameControlsClasses;
    using GameLogicAssembly.GameStatesClasses;
    using GameLogicAssembly.InitialGameStateClasses;
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
        internal List<List<Button>> AllButtons;
        internal List<Button> SelectionButtons;
        internal List<Button> MovementButtons;
        internal List<Button> BallActionButtons;
        internal List<Button> NoBallButtons;
        internal List<Button> DefenseButtons;
        internal List<Button> EndTurnButtons;

        public MainWindow()
        {
            InitializeComponent();

            InitializeButtonLists();
            AllButtons.CollapseAll();
        }

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

            // Display the appropriate buttons.
            DisplayControlButtons();
        }

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
        /// Group buttons in groups for ease of access.
        /// </summary>
        private void InitializeButtonLists()
        {
            //// Buttons: Prev, Next
            SelectionButtons = new List<Button>();
            SelectionButtons.Add(PrevPlayerBtn);
            SelectionButtons.Add(NextPlayerBtn);

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
            AllButtons.CollapseAll();

            // Always display Movement and End Turn
            MovementButtons.DisplayButtons();
            EndTurnButtons.DisplayButtons();

            // Pick Action Button group
            var buttonGroup = FootballPlayerControls.GetButtonGroupToDisplay();
            AllButtons[buttonGroup].DisplayButtons();
        }
    }
}
