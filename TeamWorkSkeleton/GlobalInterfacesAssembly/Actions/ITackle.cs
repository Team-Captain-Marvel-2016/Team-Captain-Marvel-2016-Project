namespace Global.Contracts.Actions
{
    using Statistics;

    public interface ITackle
    {
        bool Tackle(IOffenseStats enemy);
    }
}