namespace Global.Contracts
{
    using Actions;
    using Statistics;

    public interface IFootballPlayer
        : IFootballPlayerActions, IFootballPlayerStats, IDrawOnCanvas
    {
        string Name { get; }
        string Position { get; }
    }
}