namespace TeamWork.Models.PC.Reimplementation.Models
{
    using Contracts;
    using System;
    using System.Windows.Media;
    using Global.Enumerations.Team;
    using Global.Settings.Visualization;

    public class PlayerOne : IPlayer
    {
        private static PlayerOne instance = new PlayerOne();

        private PlayerOne()
        {

        }

        public static PlayerOne Instance => instance;

        public static void Initialize(IPlayerCharacter playerCharacter)
        {
            Instance.PlayerCharacter = playerCharacter;

            Instance.PlayerCharacter.Color = Brushes.Blue;

            Instance.PlayerCharacter.ResetVisualTokenColor();

            Instance.PlayerCharacter.ResetVisualTokenSize();

            Instance.PlayerCharacter.Team
                .GetInitialFootballPlayerPositions(
                    PlayingFieldSettings.GridRows,
                    PlayingFieldSettings.GridCols,
                    StartingFieldType.Left);
        }

        public IPlayerCharacter PlayerCharacter { get; private set; }

        private void OnReset(object sender, EventArgs args)
        {
            this.PlayerCharacter = null;
        }
    }
}