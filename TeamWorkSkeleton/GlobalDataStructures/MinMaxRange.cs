namespace Global.DataStructures
{
    using System;

    /// <summary>
    /// Used for setting ranges for the 
    /// FootballPlayer factory random generation.
    /// </summary>
    public struct MinMaxRange
    {
        private int min;
        private int max;

        public MinMaxRange(int min, int max)
            : this()
        {
            this.Min = min;
            this.Max = max;
        }
        
        public int Min
        {
            get
            {
                return this.min;
            }
            private set
            {
                if (!(0 <= value && value <= 100))
                {
                    throw new Exception("Value must be in the range 0-100");
                }
                else
                {
                    this.min = value;
                }
            }
        }

        public int Max
        {
            get
            {
                return this.max;
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
                    this.max = value;
                }
            }
        }
    }
}
