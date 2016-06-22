namespace TeamWork.Models.Abstract
{
    using System;
    using GlobalInterfacesAssembly.GameLogicInterfaces;
    using GlobalInterfacesAssembly.StatsInterfaces;

    public abstract partial class FootballPlayer : ITackle
    {
        public bool Tackle(IOffenseStats enemy)
        {
            throw new NotImplementedException();
        }
    }
}
