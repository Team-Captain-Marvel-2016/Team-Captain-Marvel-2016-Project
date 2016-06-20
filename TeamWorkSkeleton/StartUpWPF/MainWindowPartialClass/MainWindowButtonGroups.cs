using System.Windows;

namespace StartUpWPF
{
    using GameLogicAssembly.GameControlsClasses;
    using System.Windows.Controls;
    using System.Collections.Generic;
    using UserInterfaceAssembly.UserControlsClasses;

    public partial class MainWindow
    {
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
