namespace GlobalInterfacesAssembly.GameLogicInterfaces
{
    using StatsInterfaces;

    public interface IShoot
    {
        bool Shoot(IDefenseStats enemy);
    }
}