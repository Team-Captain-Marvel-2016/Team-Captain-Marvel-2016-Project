namespace Global.Contracts
{
    using Enumerations.Factory;

    public interface IFactory
    {
        IFootballPlayer CreatePlayerByPosition(PositionType position);
    }
}
