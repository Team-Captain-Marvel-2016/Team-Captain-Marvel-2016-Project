namespace FootballPlayerAssembly.FootballPlayerAbstractClass
{
    using System;
    using FootballPlayerFactoryClasses;
    using GameLogicInterfacesAssembly;

    public abstract partial class FootballPlayer : ICallForPass
    {
        private FootballPlayerFactory.GenericFootballPlayer player;

        public FootballPlayer(FootballPlayerFactory.GenericFootballPlayer player)
        {
            this.player = player;
        }

        public void CallForPass()
        {
            throw new NotImplementedException();
        }
    }
}
