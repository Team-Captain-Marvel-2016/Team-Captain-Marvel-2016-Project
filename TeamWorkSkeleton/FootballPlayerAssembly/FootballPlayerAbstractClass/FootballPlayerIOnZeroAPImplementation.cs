namespace FootballPlayerAssembly.FootballPlayerAbstractClass
{
    using System;
    using GlobalInterfacesAssembly.Interfaces;

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
            var handler = this.ZeroActionPoints;
            handler?.Invoke(this, null);
        }
    }
}
