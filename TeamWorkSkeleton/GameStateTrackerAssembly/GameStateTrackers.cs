namespace GameStateTrackerAssembly
{
    using System.Drawing;
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using PlayerAssembly.AbstractPlayerClass;

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
        public static FootballPlayer SelectedFootballPlayer { get; set; }
        public static FootballPlayer FootballPlayerWithBall { get; set; }
        public static Brushes OldFootballPlayerColor { get; set; }
        }
}
