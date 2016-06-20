namespace FootballPlayerAssembly.FootballPlayerAbstractClass
{
    using Interfaces;
    using System;

    public abstract partial class FootballPlayer : IOnZeroActionPoints
    {
        public event EventHandler ZeroActionPoints;

        public void ResetActionPoints()
        {
            this.CurrentAP = this.ActionPoints;
        }

        private void DecrementActionPoints()
        {
            this.CurrentAP--;

            if (this.CurrentAP == 0)
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
