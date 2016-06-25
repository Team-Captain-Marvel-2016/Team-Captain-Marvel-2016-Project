namespace Global.DataStructures
{
    // ReSharper disable once InconsistentNaming
    /// <summary>
    /// Used for tracking position in a grid easily.
    /// </summary>
    public struct PositionXY
    {
        private int x;
        private int y;

        public PositionXY(int x, int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }

        // TODO: Validate props
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
    }
}
