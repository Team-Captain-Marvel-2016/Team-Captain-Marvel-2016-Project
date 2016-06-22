namespace TeamWork.Models.Abstract
{
    using System;
    using Global.Contracts.Actions;
    using Global.Contracts.Statistics;

    public abstract partial class FootballPlayer : IShoot
    {
        public bool Shoot(IDefenseStats enemy)
        {
            throw new NotImplementedException();
        }
    }
}

