namespace GameLogicAssembly
{
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using PlayerAssembly.AbstractPlayerClass;

    public static class GameStateTrackers
    {
        static GameStateTrackers()
        {
            GameLengthTurns = 20;
        }
        
        public static int GameLengthTurns { get; private set; }

        public static int TurnNumber { get; set; }

        public static PlayerCharacter PlayerOnTurn { get; set; }
        public static FootballPlayer SelecterFootballPlayer { get; set; }
    }
}
