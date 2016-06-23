namespace Game.Tracker
{
    using Global.Contracts;
    using System.Drawing;
    using Teamwork.Models.PC.Abstract;
    using Teamwork.Models.PC.Human.Singletons;

    public static class GameStateTracker
    {
        static GameStateTracker()
        {
            GameLengthTurns = 20;
        }

        public static int GameLengthTurns { get; private set; }

        public static int TurnNumber { get; set; }

        public static PlayerCharacter PlayerOnTurn { get; set; }
        public static PlayerCharacter PlayerWihBall { get; set; }
        public static IFootballPlayer SelectedFootballPlayer { get; set; }
        public static IFootballPlayer FootballPlayerWithBall { get; set; }
        public static IFootballPlayer TargetFootballPlayer { get; set; }
        public static Brushes OldFootballPlayerColor { get; set; }

        public static PlayerCharacter GetOpponent()
        {
            var opponent = GameStateTracker.PlayerOnTurn is PlayerOne
                ? PlayerTwo.Player
                : PlayerOne.Player;

            return opponent;
        }
    }
}

