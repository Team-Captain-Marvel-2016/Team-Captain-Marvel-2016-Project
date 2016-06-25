namespace Global.Settings.Visualization
{
    using System.Windows.Media;

    /// <summary>
    /// Setes the visualization settings for 
    /// disaplying a IDrawOnCanvas.VisualToken 
    /// of a FootballPlayer.
    /// </summary>
    public static class FootballPlayerSettings
    {
        static FootballPlayerSettings()
        {
            VisualTokenSize = 15;
            SelectedVisualTokenSize = 25;
            BallColor = Brushes.FloralWhite;
        }

        public static int VisualTokenSize { get; private set; }
        public static int SelectedVisualTokenSize { get; private set; }
        public static SolidColorBrush BallColor { get; private set; }
    }
}
