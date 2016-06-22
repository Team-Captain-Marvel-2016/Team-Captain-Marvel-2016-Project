namespace GlobalInterfacesAssembly.GameLogicInterfaces
{
    using StatsInterfaces;

    public interface ITackle
    {
        bool Tackle(IOffenseStats enemy);
    }
}