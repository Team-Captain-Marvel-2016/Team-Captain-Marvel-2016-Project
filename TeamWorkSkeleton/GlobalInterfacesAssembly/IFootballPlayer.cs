namespace Global.Contracts
{
    using Actions;
    using Statistics;

    /// <summary>
    /// Extends all offensive and defensive stats
    /// from their corresponding interfaces.
    /// Extends the IDrawOnCanvas interface.
    /// </summary>
    public interface IFootballPlayer
        : IFootballPlayerActions, IFootballPlayerStats, IDrawOnCanvas
    {
        string Name { get; }
        string Position { get; }
    }
}