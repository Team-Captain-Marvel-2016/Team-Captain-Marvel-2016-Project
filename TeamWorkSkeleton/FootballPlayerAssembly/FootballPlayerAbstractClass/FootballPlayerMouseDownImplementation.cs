namespace FootballPlayerAssembly.FootballPlayerAbstractClass
{
    using System;

    public abstract partial class FootballPlayer
    {
        public void OnMouseDown(object sender, EventArgs args)
        {
            this.IsTargeted = true;
        }
    }
}
