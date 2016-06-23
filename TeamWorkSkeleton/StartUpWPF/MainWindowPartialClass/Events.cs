namespace StartUpWPF
{
    using System;
    using Teamwork.Models.PC.Human.Singletons;

    public partial class MainWindow
    {
        private void SubscribeToFootballPlayerEvents()
        {
            foreach (var footballPlayer in PlayerOne.Player.Team.Team)
            {
                footballPlayer.ZeroActionPoints += OnZeroActionPoints;
            }

            foreach (var footballPlayer in PlayerTwo.Player.Team.Team)
            {
                footballPlayer.ZeroActionPoints += OnZeroActionPoints;
            }
        }

        private void OnZeroActionPoints(object sender, EventArgs args)
        {
            this.Buttons.Enable();
            this.DisplayUIZeroAP?.Invoke(this, null);
        }
    }
}
