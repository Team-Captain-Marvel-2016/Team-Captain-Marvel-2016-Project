namespace FootballPlayerAssembly.FootballPlayerAbstractClass
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
