namespace Global.Contracts.Actions
{
    public interface IFootballPlayerActions
        : ICallForPass, IControlMovement, IGameMechanics, IGameStateTrackable, IPass, IShoot, ITackle
    {

    }
}