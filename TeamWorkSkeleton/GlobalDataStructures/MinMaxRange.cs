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
        
        public int Min
        {
            get
            {
                return _min;
            }
            private set
            {
                if (!(0 <= value && value <= 100))
                {
                    throw new Exception("Value must be in the range 0-100");
                }
                else
                {
                    _min = value;
                }
            }
        }

        public int Max
        {
            get
            {
                return _max;
            }
            private set
            {
                if (!(1 <= value && value <= 100)
                    && value < this.Min)
                {
                    throw new Exception("Value must be in the range 0-100");
                }
                else
                {
                    _max = value;
                }
            }
        }
    }
}
