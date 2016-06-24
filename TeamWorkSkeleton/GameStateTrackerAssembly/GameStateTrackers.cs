namespace Game.Tracker
{
    using Global.Contracts;
    using System.Drawing;
    using TeamWork.Models.PC.Reimplementation.Contracts;

    public static class GameStateTracker
    {
        static GameStateTracker()
        {
            GameLengthTurns = 20;
        }

        public static int GameLengthTurns { get; private set; }

        public static int TurnNumber { get; set; }

        public static IPlayer PlayerOnTurn { get; set; }
        public static IPlayer PlayerWihBall { get; set; }
        public static IFootballPlayer SelectedFootballPlayer { get; set; }
        public static IFootballPlayer FootballPlayerWithBall { get; set; }
        public static IFootballPlayer TargetFootballPlayer { get; set; }
        public static Brushes OldFootballPlayerColor { get; set; }

        public static IPlayer GetOpponent()
        {
            var opponent = GameStateTracker.PlayerOnTurn is TeamWork.Models.PC.Reimplementation.Models.PlayerOne
                ? (IPlayer) TeamWork.Models.PC.Reimplementation.Models.PlayerTwo.Instance
                : (IPlayer) TeamWork.Models.PC.Reimplementation.Models.PlayerOne.Instance;

            return opponent;
        }
    }
}

