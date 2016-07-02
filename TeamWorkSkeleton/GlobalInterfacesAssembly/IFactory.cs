namespace Global.Contracts
{
    using Enumerations.Factory;

    interface IFactory
    {
        IFootballPlayer CreatePlayerByPosition(PositionType position);
    }
}
