namespace Global.Contracts
{
    using System.Windows.Controls;

    public interface IGameVisualizer
    {
        Canvas GameCanvas { get; }
    }
}