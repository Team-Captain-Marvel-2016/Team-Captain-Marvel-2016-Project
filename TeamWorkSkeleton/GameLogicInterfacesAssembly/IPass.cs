namespace GameLogicInterfacesAssembly
{
    using GlobalInterfacesAssembly.Interfaces;

    public interface IPass
    {
        bool Pass(IDefenseStats enemy);
    }
}