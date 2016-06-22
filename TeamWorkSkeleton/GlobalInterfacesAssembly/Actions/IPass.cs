namespace Global.Contracts.Actions
{
    using Statistics;

    public interface IPass
    {
        bool Pass(IDefenseStats enemy);
    }
}