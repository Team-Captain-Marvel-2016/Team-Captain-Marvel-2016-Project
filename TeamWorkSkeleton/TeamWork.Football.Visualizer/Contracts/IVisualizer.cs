namespace TeamWork.Football.Visualizer.Contracts
{
    using Global.Contracts;
    using Global.DataStructures;
    using System.Collections.Generic;
    using System.Windows.Controls;
    using System.Windows.Media;

    /// <summary>
    /// Interface for displaying 
    /// IDrawOnCanvas objects on a grid.
    /// </summary>
    public interface IVisualizer
    {
        int Width { get; }
        int Height { get; }

        ICollection<IDrawOnCanvas> Children { get; }

        Canvas GameCanvas { get; }

        void Add(IEnumerable<IDrawOnCanvas> elements);

        void Remove(IEnumerable<IDrawOnCanvas> elements);

        void SetPosition(IEnumerable<IDrawOnCanvas> elements);

        void SetTokenSize(IDrawOnCanvas child, int newWidth, int newHeight);

        void SetTokenColor(IDrawOnCanvas child, SolidColorBrush color);

        void Reset();

        void SetGridPosition(IEnumerable<IDrawOnCanvas> elements, PositionXY[,] grid);
    }
}