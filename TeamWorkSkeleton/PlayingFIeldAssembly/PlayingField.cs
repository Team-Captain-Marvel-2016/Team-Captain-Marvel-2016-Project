namespace Game.PlayingField
{
    using System;
    using Global.Settings.Visualization;

    /// <summary>
    /// Creates a bool[] tracking FootballPlayer positions.
    /// Playing is created based on PlayingFieldSettings.
    /// </summary>
    public static class PlayingField
    {
        static PlayingField()
        {
            Field = InitField();

            //ResetGameState.ResetGameEvent += OnResetEvent;
        }

        public static bool[,] Field { get; set; }

        private static void OnResetEvent(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create the bool[] based on preset settings.
        /// </summary>
        /// <returns></returns>
        private static bool[,] InitField()
        {
            var rows = PlayingFieldSettings.GridRows;
            var cols = PlayingFieldSettings.GridCols;

            var field = new bool[rows, cols];

            return field;
        }
    }
}


