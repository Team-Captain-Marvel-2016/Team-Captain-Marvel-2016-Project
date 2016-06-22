namespace GlobalInterfacesAssembly.GameLogicInterfaces
{
    using StatsInterfaces;

    public interface IPass
    {
        bool Pass(IDefenseStats enemy);
    }
}