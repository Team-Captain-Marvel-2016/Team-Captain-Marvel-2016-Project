namespace GlobalInterfacesAssembly.GameLogicInterfaces
{
    using StatsInterfaces;

    public interface ICallForPass
    {
        bool CallForPass(IDefenseStats enemey);
    }
}