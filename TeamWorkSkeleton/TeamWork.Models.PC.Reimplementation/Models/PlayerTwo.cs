namespace TeamWork.Models.PC.Reimplementation.Models
{
    using Contracts;
    using System;
    using System.Windows.Media;
    using Global.Enumerations.Team;
    using Global.Settings.Visualization;

    public class PlayerTwo : IPlayer
    {
        private static PlayerTwo instance = new PlayerTwo();

        private PlayerTwo()
        {

        }

        public static PlayerTwo Instance => instance;

        public static void Initialize(IPlayerCharacter playerCharacter)
        {
            Instance.PlayerCharacter = playerCharacter;

            Instance.PlayerCharacter.Color = Brushes.Red;

            instance.PlayerCharacter.ResetVisualTokenColor();

            instance.PlayerCharacter.ResetVisualTokenSize();

            Instance.PlayerCharacter.Team
                .GetInitialFootballPlayerPositions(
                    PlayingFieldSettings.GridRows,
                    PlayingFieldSettings.GridCols,
                    StartingFieldType.Right);
        }

        public IPlayerCharacter PlayerCharacter { get; private set; }

        private void OnReset(object sender, EventArgs args)
        {
            this.PlayerCharacter = null;
        }
    }
}