namespace TeamWork.Models.Abstract
{
    using System;
    using Global.Contracts.Actions;
    using Global.Contracts.Statistics;

    public abstract partial class FootballPlayer
    {
        public bool Tackle(IOffenseStats enemy)
        {
            throw new NotImplementedException();
        }
    }
}
