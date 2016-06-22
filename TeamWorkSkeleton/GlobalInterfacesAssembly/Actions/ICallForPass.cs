namespace Global.Contracts.Actions
{
    using Statistics;

    public interface ICallForPass
    {
        bool CallForPass(IDefenseStats enemey);
    }
}