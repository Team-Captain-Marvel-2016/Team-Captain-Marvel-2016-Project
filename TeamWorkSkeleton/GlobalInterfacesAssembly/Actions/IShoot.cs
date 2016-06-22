namespace Global.Contracts.Actions
{
    using Statistics;

    public interface IShoot
    {
        bool Shoot(IDefenseStats enemy);
    }
}