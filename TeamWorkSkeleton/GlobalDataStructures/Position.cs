namespace GlobalDataStructures
{
    using System;

    public struct Position
    {
        private int _x;
        private int _y;

        public Position(int x, int y)
            : this()
        {
            X = x;
            Y = y;
        }

        // TODO: Validate props
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
    }
}
