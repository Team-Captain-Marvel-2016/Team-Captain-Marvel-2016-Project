namespace TeamWork.Models.Abstract
{
    using System;
    using GlobalInterfacesAssembly.GameLogicInterfaces;
    using GlobalInterfacesAssembly.StatsInterfaces;

    public abstract partial class FootballPlayer : ICallForPass
    {
        public bool CallForPass(IDefenseStats enemey)
        {
            throw new NotImplementedException();
        }
    }
}
