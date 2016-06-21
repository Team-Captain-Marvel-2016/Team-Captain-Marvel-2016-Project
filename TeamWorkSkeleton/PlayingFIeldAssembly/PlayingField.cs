namespace PlayingFIeldAssembly
{
    using GlobalSettingsAssembly.VisualizationSettings;
    using System;

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

        private static bool[,] InitField()
        {
            var rows = PlayingFieldVisualizationSettings.GridRows;
            var cols = PlayingFieldVisualizationSettings.GridCols;

            var field = new bool[rows, cols];

            return field;
        }
    }
}


