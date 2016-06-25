namespace Game.Tracker
{
    using Global.Contracts;
    using System.Drawing;
    using TeamWork.Models.PC.Reimplementation.Contracts;

    /// <summary>
    /// Tracks the current Game state.
    /// Player with ball, Player on turn.
    /// FootballPlayer: selected, with ball, target of a pass
    /// Saves the previous color of the current player with ball
    /// for visualization purposes.
    /// Tracks Game Score.
    /// Method for determining the player which is NOT on turn.
    /// </summary>
    public static class GameStateTracker
    {
        static GameStateTracker()
        {
            GameLengthTurns = 90;
        }

        public static int GameLengthTurns { get; private set; }

        public static int TurnNumber { get; set; }

        public static IPlayer PlayerOnTurn { get; set; }
        public static IPlayer PlayerWihBall { get; set; }
        public static IFootballPlayer SelectedFootballPlayer { get; set; }
        public static IFootballPlayer FootballPlayerWithBall { get; set; }
        public static IFootballPlayer TargetFootballPlayer { get; set; }
        public static Brushes OldFootballPlayerColor { get; set; }

        public static int PlayerOneScore { get; set; }
        public static int PlayerTwoScore { get; set; }

        /// <summary>
        /// Checks the type of the current player on turn.
        /// There can only be one instance of PlayerOne and 
        /// one instance of PlayerTwo.
        /// </summary>
        /// <returns>IPlayer object NOT on turn.</returns>
        public static IPlayer GetOpponent()
        {
            var opponent = GameStateTracker.PlayerOnTurn is TeamWork.Models.PC.Reimplementation.Models.PlayerOne
                ? (IPlayer) TeamWork.Models.PC.Reimplementation.Models.PlayerTwo.Instance
                : (IPlayer) TeamWork.Models.PC.Reimplementation.Models.PlayerOne.Instance;

            return opponent;
        }
    }
}

