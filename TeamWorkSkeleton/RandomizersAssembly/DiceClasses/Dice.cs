using RandomizersAssembly.Interfaces;
namespace RandomizersAssembly.DiceClasses
{
    using System;

    public class Dice : IRoll
    {
        private int _face;

        public Dice(int face)
        {
            this.Face = face;

            this.Random = new Random();
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

        private Random Random { get; set; }

        #region Methods

        public int Roll() => Random.Next(1, this.Face);

        #endregion

    }
}
