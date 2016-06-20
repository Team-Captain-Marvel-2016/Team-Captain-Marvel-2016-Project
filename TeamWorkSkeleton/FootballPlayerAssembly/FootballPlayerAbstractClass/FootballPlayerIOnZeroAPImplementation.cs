namespace FootballPlayerAssembly.FootballPlayerAbstractClass
{
    using Interfaces;
    using System;

    public abstract partial class FootballPlayer : IOnZeroActionPoints
    {
        public event EventHandler ZeroActionPoints;

        private void DecrementActionPoints()
        {
            this.ActionPoints--;

            if (this.ActionPoints == 0)
            {
                this.OnZeroActionPoints();
            }
        }

        protected virtual void OnZeroActionPoints()
        {
            var handler = ZeroActionPoints;
            handler?.Invoke(this, null);
        }
    }
}
