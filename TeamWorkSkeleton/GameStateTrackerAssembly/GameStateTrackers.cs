namespace GameStateTrackerAssembly
{
    using System.Drawing;
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using PlayerAssembly.AbstractPlayerClass;
    using PlayingFIeldAssembly;
    using VisualizationAssembly.VisualizationStaticSettingsClasses;

    public static class GameStateTracker
    {
        static GameStateTracker()
        {
            GameLengthTurns = 20;
            InitBoolGrid();
        }
        
        public static int GameLengthTurns { get; private set; }

        public static int TurnNumber { get; set; }

        public static PlayerCharacter PlayerOnTurn { get; set; }
        public static PlayerCharacter PlayerWihBall { get; set; }
        public static FootballPlayer SelectedFootballPlayer { get; set; }
        public static FootballPlayer FootballPlayerWithBall { get; set; }
        public static Brushes OldFootballPlayerColor { get; set; }

        public static PlayingField HasPlayerAtPosition { get; set; }

        private static void InitBoolGrid()
        {
            var rows = PlayingFieldVisualizationSettings.GridRows;
            var cols = PlayingFieldVisualizationSettings.GridCols;
            HasPlayerAtPosition = new PlayingField(rows, cols);
        }
    }
}
