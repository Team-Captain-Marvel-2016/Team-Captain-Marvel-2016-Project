namespace TeamWork.Models.PC.Reimplementation.Models
{
    using Contracts;
    using System;
    using System.Windows.Media;
    using Global.Enumerations.Team;
    using Global.Settings.Visualization;

    /// <summary>
    /// Allows a single instance of PlayerOne to exist.
    /// 
    /// </summary>
    public class PlayerOne : IPlayer
    {
        private static PlayerOne instance = new PlayerOne();

        private PlayerOne()
        {

        }

        public static PlayerOne Instance => instance;

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

            Instance.PlayerCharacter.Color = Brushes.Blue;

            Instance.PlayerCharacter.ResetVisualTokenColor();

            Instance.PlayerCharacter.ResetVisualTokenSize();

            Instance.PlayerCharacter.Team
                .GetInitialFootballPlayerPositions(
                    PlayingFieldSettings.GridRows,
                    PlayingFieldSettings.GridCols,
                    StartingFieldType.Left);
        }

        /// <summary>
        /// Access the PlayerOne instance.
        /// </summary>
        public IPlayerCharacter PlayerCharacter { get; private set; }

        private void OnReset(object sender, EventArgs args)
        {
            this.PlayerCharacter = null;
        }
    }
}