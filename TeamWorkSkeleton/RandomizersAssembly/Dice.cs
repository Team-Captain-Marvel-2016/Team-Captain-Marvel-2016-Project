namespace Global.Randomization
{
    using System;
    using Contracts;

    /// <summary>
    /// Create a Dice object, pass a face value ( number of sides ).
    /// Implements IDiceRoll, returns an int random value in range ( 1 - Face ).
    /// </summary>
    public class Dice : IDiceRoll
    {
        private int _face;

        public Dice(int face)
        {
            this.Face = face;
        }

        private int Face
        {
            get
            {
                return this._face;
            }
            set
            {
                if (!(1 <= value && value <= 100))
                {
                    throw new Exception("Value must be between 1 and 100");
                }
                else
                {
                    this._face = value;
                }
            }
        }

        public int Roll()
            => GenericRandomization.Random.Next(1, this.Face);
    }
}
