namespace StartUpWPF
{
    using System.Windows.Controls;
    using System.Collections.Generic;
    using UserControls;
    using UserInterfaceAssembly.UserControlsClasses;

    public partial class MainWindow
    {
        /// <summary>
        /// Group buttons in groups for ease of access.
        /// </summary>
        private void InitializeButtonLists()
        {
            //// Buttons: Prev, Next
            this.SelectionButtons = new List<Button>();
            //SelectionButtons.Add(PrevPlayerBtn);
            //SelectionButtons.Add(NextPlayerBtn);

            // Buttons: Up, Down, Left, Right
            this.MovementButtons = new List<Button>();
            this.MovementButtons.Add(this.MoveUpBtn);
            this.MovementButtons.Add(this.MoveDownBtn);
            this.MovementButtons.Add(this.MoveLeftBtn);
            this.MovementButtons.Add(this.MoveRightBtn);

            // Buttons: Pass, Shoot
            this.BallActionButtons = new List<Button>();
            this.BallActionButtons.Add(this.PassBtn);
            this.BallActionButtons.Add(this.ShootBtn);

            // TODO: Create offense without ball button
            // TODO: Create defense tackle button
            // Button: Call For Pass
            this.NoBallButtons = new List<Button>();
            this.NoBallButtons.Add(this.CallForPassBtn);

            // Buttons: Tackle
            this.DefenseButtons = new List<Button>();
            this.DefenseButtons.Add(this.TackleBtn);

            // Buttons: End Turn
            this.EndTurnButtons = new List<Button>();
            this.EndTurnButtons.Add(this.EndTurnBtn);
            this.EndTurnButtons.Add(this.ResetBtn);

            // TODO: Add the remaining two lists
            // All Buttons
            this.AllButtons = new List<List<Button>>();
            this.AllButtons.Add(this.SelectionButtons);
            this.AllButtons.Add(this.MovementButtons);
            this.AllButtons.Add(this.BallActionButtons);
            this.AllButtons.Add(this.NoBallButtons);
            this.AllButtons.Add(this.DefenseButtons);
            this.AllButtons.Add(this.EndTurnButtons);
        }

        /// <summary>
        /// Display appropriate Button group.
        /// </summary>
        private void DisplayControlButtons()
        {
            // Hide all 
            this.AllButtons.DisableAll();

            //// Always display Movement and End Turn
            //MovementButtons.DisplayButtons();
            //EndTurnButtons.DisplayButtons();

            this.MovementButtons.EnableButtons();
            this.EndTurnButtons.EnableButtons();

            // Pick Action Button group
            var buttonGroup =
                FootballPlayerControls.GetButtonGroupToDisplay();

            this.AllButtons[buttonGroup].EnableButtons();
        }
    }
}
