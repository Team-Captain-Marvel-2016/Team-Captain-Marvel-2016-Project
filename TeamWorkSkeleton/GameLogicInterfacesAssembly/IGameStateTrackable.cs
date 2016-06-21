namespace GameLogicInterfacesAssembly
{
    public interface IGameStateTrackable
    {
        bool HasBall { get; set; }
        bool IsSelected { get; set; }
        bool IsTargeted { get; set; }
    }
}