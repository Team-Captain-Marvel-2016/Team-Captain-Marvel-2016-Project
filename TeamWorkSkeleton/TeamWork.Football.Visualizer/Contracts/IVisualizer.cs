namespace TeamWork.Football.Visualizer.Contracts
{
    using Global.Contracts;
    using System.Collections.Generic;
    using System.Windows.Controls;
    using System.Windows.Media;

    public interface IVisualizer
    {
        int Width { get; }
        int Height { get; }

        List<IDrawOnCanvas> Children { get; }

        Canvas GameCanvas { get; }

        void Add(IEnumerable<IDrawOnCanvas> elements);

        void Remove(IEnumerable<IDrawOnCanvas> elements);

        void SetPosition(IEnumerable<IDrawOnCanvas> elements);

        void MarkCurrentPlayer(IDrawOnCanvas child, int newWidth, int newHeight);

        void MarkPlayerWithBall(IDrawOnCanvas child, SolidColorBrush color);

        void Reset();
    }
}