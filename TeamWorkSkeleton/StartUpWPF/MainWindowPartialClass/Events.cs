namespace StartUpWPF
{
    using System;
    using TeamWork.Models.PC.Reimplementation.Models;

    public partial class MainWindow
    {
        /// <summary>
        /// Each Football Player has a ZeroActionPoints event.
        /// Subscribe to all of those events when initializing the game.
        /// OnZeroAP all buttons are hidden, but End Turn and Reset.
        /// Signaliing the player is obliged to end the turn.
        /// </summary>
        private void SubscribeToFootballPlayerEvents()
        {
            foreach (var footballPlayer in PlayerOne.Instance.PlayerCharacter.Team.Team)
            {
                footballPlayer.ZeroActionPoints += this.OnZeroActionPoints;
            }

            foreach (var footballPlayer in PlayerTwo.Instance.PlayerCharacter.Team.Team)
            {
                footballPlayer.ZeroActionPoints += this.OnZeroActionPoints;
            }
        }

        /// <summary>
        /// Invoke the appropriate event
        /// hide/ display UI buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnZeroActionPoints(object sender, EventArgs args)
        {
            this.Buttons.Enable();
            this.DisplayUIZeroAP?.Invoke(this, null);
        }
    }
}
