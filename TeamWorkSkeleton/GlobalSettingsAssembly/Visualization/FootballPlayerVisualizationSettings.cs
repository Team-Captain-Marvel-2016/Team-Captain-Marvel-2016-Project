namespace Global.Settings.Visualization
{
    public static class FootballPlayerVisualizationSettings
    {
        static FootballPlayerVisualizationSettings()
        {
            VisualTokenSize = 15;
            SelectedVisualTokenSize = 25;
        }

        public static int VisualTokenSize { get; private set; }
        public static int SelectedVisualTokenSize { get; private set; }
    }
}
