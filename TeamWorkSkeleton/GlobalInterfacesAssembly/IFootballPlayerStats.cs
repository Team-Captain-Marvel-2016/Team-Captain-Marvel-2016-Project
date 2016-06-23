namespace Global.Contracts
{
    using Statistics;

    public interface IFootballPlayerStats 
        : IDefenseStats, IOffenseStats, IOnZeroActionPoints, IOrigin
    {
        
    }
}