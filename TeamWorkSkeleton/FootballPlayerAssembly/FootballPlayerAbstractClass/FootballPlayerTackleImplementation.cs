namespace FootballPlayerAssembly.FootballPlayerAbstractClass
{
    using System;
    using GlobalInterfacesAssembly.GameLogicInterfaces;

    public abstract partial class FootballPlayer : ITackle
    {
        public void Tackle()
        {
            throw new NotImplementedException();
        }
    }
}
