namespace Global.Contracts.Statistics
{
    public interface IOffenseStats
    {
        int StatPass { get; }
        int StatShoot { get; }
        int StatDribble { get; }
    }
}