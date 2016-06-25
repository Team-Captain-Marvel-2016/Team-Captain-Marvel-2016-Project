namespace TeamWork.Models.PC.Reimplementation.Models
{
    using Contracts;
    using Global.Enumerations.Team;
    using Global.Settings.Visualization;
    using System;
    using System.Windows.Media;

    /// <summary>
    /// Allos for a single instance of PlayerTwo to exist.
    /// </summary>
    public class PlayerTwo : IPlayer
    {
        private static PlayerTwo instance = new PlayerTwo();

        private PlayerTwo()
        {

        }

        public static PlayerTwo Instance => instance;

        /// <summary>
        /// Initialize the instance of the class.
        /// Assign color.
        /// Innitialize the VisualToken of each player to 
        /// the size and color in FootBallPlayer visual settings.
        /// Get the initial grid and pixel coordinates of each football player.
        /// </summary>
        /// <param name="playerCharacter"></param>
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