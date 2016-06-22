namespace TeamWork.Models.Abstract
{
    using System;
    using GlobalInterfacesAssembly.GameLogicInterfaces;
    using GlobalInterfacesAssembly.StatsInterfaces;

    public abstract partial class FootballPlayer : IShoot
    {
        public bool Shoot(IDefenseStats enemy)
        {
            throw new NotImplementedException();
        }
    }
}

