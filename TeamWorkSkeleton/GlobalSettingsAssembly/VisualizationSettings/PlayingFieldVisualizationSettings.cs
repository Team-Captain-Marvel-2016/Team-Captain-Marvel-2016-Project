namespace GlobalSettingsAssembly.VisualizationSettings
{
    using GlobalDataStructures;

    public static class PlayingFieldVisualizationSettings
    {
        static PlayingFieldVisualizationSettings()
        {
            Width = 640;
            HalfWidth = Width / 2;
            Height = 400;
            Step = 40;

            GenerateGrid();
        }

        public static int Width { get; private set; }
        public static int HalfWidth { get; private set; }
        public static int Height { get; private set; }
        public static int Step { get; private set; }

        // Generate a grid of coordinates
        public static int GridRows { get; private set; }
        public static int GridCols { get; private set; }

        public static PositionXY[,] GridCoordinates { get; private set; }

        private static void GenerateGrid()
        {
            GridCols = (Width / Step) - 1;
            GridRows = (Height / Step) - 1;

            GridCoordinates = new PositionXY[GridRows, GridCols];

            // Fill Col coordinates.
            var fillX = 30;
            for (var row = 0; row < GridRows; row++)
            {
                var fillY = 30;

                for (var col = 0; col < GridCols; col++)
                {
                    var add = new PositionXY(fillX, fillY);

                    GridCoordinates[row, col] = add;
                    fillY += Step;
                }

                fillX += Step;
            }
        }
    }
}
