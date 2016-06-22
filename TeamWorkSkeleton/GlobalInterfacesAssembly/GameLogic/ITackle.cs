namespace Global.Contracts.GameLogic
{
    using GlobalInterfacesAssembly.StatsInterfaces;

    public interface ITackle
    {
        bool Tackle(IOffenseStats enemy);
    }
}