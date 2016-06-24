namespace StartUpWPF
{
    using System;
    using TeamWork.Models.PC.Reimplementation.Models;

    public partial class MainWindow
    {
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

        private void OnZeroActionPoints(object sender, EventArgs args)
        {
            this.Buttons.Enable();
            this.DisplayUIZeroAP?.Invoke(this, null);
        }
    }
}
