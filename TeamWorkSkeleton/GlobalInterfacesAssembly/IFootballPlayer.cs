namespace Global.Contracts
{
    public interface IFootballPlayer
        : IFootballPlayerActions, IFootballPlayerStats, IDrawOnCanvas
    {
        string Name { get; }
        string Position { get; }
    }
}