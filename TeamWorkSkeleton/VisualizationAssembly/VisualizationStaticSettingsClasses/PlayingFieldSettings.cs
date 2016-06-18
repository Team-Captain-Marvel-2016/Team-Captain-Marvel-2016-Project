namespace VisualizationAssembly.VisualizationStaticSettingsClasses
{
    public static class PlayingFieldSettings
    {
        static PlayingFieldSettings()
        {
            Width = 640;
            Height = 400;
            Step = 40;
        }

        public static int Width { get; private set; }
        public static int Height { get; private set; }
        public static int Step { get; private set; }

    }
}
