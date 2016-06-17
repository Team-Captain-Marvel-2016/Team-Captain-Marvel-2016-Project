namespace GlobalDataStructures
{
    using System;

    public struct MinMaxRange
    {
        private int _min;
        private int _max;

        public MinMaxRange(int min, int max)
            : this()
        {
            Min = min;
            Max = max;
        }

        // TODO: Validate props
        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }

        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }
    }
}
