namespace TeamWork.Models.Abstract
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
