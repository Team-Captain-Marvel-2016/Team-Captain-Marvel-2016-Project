namespace Global.Contracts
{
    using Actions;

    public interface IFootballPlayerActions
        : ICallForPass, IControlMovement, IGameMechanics, IGameStateTrackable, IPass, IShoot, ITackle
    {

    }
}