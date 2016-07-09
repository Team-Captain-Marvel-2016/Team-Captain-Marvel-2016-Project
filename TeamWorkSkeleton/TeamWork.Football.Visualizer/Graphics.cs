namespace TeamWork.Football.Visualizer
{
    using Contracts;
    using Global.Contracts;
    using Global.DataStructures;
    using System;
    using System.Collections.Generic;
    using System.Windows.Controls;
    using System.Windows.Media;

    /// <summary>
    /// Implements the IVisualizer interface 
    /// to display each VisualToken on Canvas control.
    /// </summary>
    public sealed class Graphics : IVisualizer
    {
        public Graphics(Canvas canvas, int width, int height)
        {
            this.GameCanvas = canvas;
            this.Width = width;
            this.Height = height;

            this.Children = new List<IDrawOnCanvas>();
        }

        public ICollection<IDrawOnCanvas> Children { get; private set; }

        public int Width { get; private set; }

        public int Height { get; private set; }

        public Canvas GameCanvas { get; private set; }

        public void Add(IEnumerable<IDrawOnCanvas> elements)
        {
            // Validate.
            foreach (var drawOnCanvas in elements)
            {
                drawOnCanvas.CanvasChildIndex = this.Children.Count;
                this.Children.Add(drawOnCanvas);
                this.GameCanvas.Children.Add(drawOnCanvas.VisualToken);
            }
        }

        public void Remove(IEnumerable<IDrawOnCanvas> elements)
        {
            // Validate.
            foreach (var drawOnCanvas in elements)
            {
                this.Children.Remove(drawOnCanvas);
                this.GameCanvas.Children.Remove(drawOnCanvas.VisualToken);
            }
        }

        public void SetPosition(IEnumerable<IDrawOnCanvas> elements)
        {
            // Validate.
            foreach (var drawOnCanvase in elements)
            {
                if (drawOnCanvase.CanvasChildIndex == null)
                {
                    throw new ArgumentException(
                        "FootballPlayer Canvas Index is null");
                }

                Canvas.SetLeft(drawOnCanvase.VisualToken, drawOnCanvase.FieldPosition.Y);
                Canvas.SetTop(drawOnCanvase.VisualToken, drawOnCanvase.FieldPosition.X);

                this.GameCanvas.Children[
                    drawOnCanvase.CanvasChildIndex.Value] =
                        drawOnCanvase.VisualToken;
            }
        }

        public void SetTokenSize(IDrawOnCanvas child, int newWidth, int newHeight)
        {
            if (child.CanvasChildIndex == null)
            {
                throw new Exception("Child does not have a valid CanvasIndex");
            }

            child.VisualToken.Width
                = newWidth;
            child.VisualToken.Height
                = newHeight;

            this.GameCanvas.Children[child.CanvasChildIndex.Value] = child.VisualToken;
        }

        public void SetTokenColor(IDrawOnCanvas child, SolidColorBrush color)
        {
            if (child.CanvasChildIndex == null)
            {
                throw new Exception("Child does not have a valid CanvasIndex");
            }

            child.VisualToken.Fill = color;
        }

        public void SetGridPosition(IEnumerable<IDrawOnCanvas> elements, PositionXY[,] grid)
        {

            foreach (var child in elements)
            {
                // Get new Field Postion based on GridPosition
                var fieldRow = child.GridPosition.X;
                var fieldCol = child.GridPosition.Y;

                var newFieldPosition = grid[fieldRow, fieldCol];

                child.FieldPosition = newFieldPosition;

                // Apply new position.
                Canvas.SetTop(child.VisualToken, child.FieldPosition.X);
                Canvas.SetLeft(child.VisualToken, child.FieldPosition.Y);
            }
        }

        public void Reset()
        {
            this.Children.Clear();
            this.GameCanvas.Children.Clear();
        }
    }
}