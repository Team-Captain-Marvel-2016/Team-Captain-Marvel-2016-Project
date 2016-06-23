namespace VisualizationAssembly.CanvasUtilsClasses
{
    using System;
    using System.Windows.Controls;
    using System.Windows.Media;
    using Global.Contracts;
    using Global.Settings.Visualization;

    public static class CanvasChildrenUtilities
    {
        /// <summary>
        /// Add a new element to Canvas.Children.
        /// Element must implement IDrawOnCanvas.
        /// If the element already has an assigned CanvasIndex
        /// abort operation with exception. ( element has already been added )
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="canvas"></param>
        /// <param name="child"></param>
        public static void AddChild<T>(Canvas canvas, T child)
            where T : IDrawOnCanvas
        {
            if (child.CanvasChildIndex != null)
            {
                throw new Exception("Child already exists");
            }

            var numberOfChildren = canvas.Children.Count;

            // Position the child.
            UpdateCanvasPositionCoordinates(child);

            canvas.Children.Add(child.VisualToken);
            child.CanvasChildIndex = numberOfChildren;
        }

        /// <summary>
        /// Updates the position of an already existing
        /// child element in a Canvas.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="canvas"></param>
        /// <param name="child"></param>
        public static void UpdateCanvasPosition<T>(Canvas canvas, T child)
            where T : IDrawOnCanvas
        {
            if (child.CanvasChildIndex == null)
            {
                throw new Exception("Child does not have a valid CanvasIndex");
            }

            UpdateCanvasPositionCoordinates(child);
            canvas.Children[child.CanvasChildIndex.Value] = child.VisualToken;
        }

        public static void MarkCurrentPlayer<T>(Canvas canvas, T child)
            where T : IDrawOnCanvas
        {
            if (child.CanvasChildIndex == null)
            {
                throw new Exception("Child does not have a valid CanvasIndex");
            }

            child.VisualToken.Width
                = FootballPlayerSettings.SelectedVisualTokenSize;
            child.VisualToken.Height
                = FootballPlayerSettings.SelectedVisualTokenSize;

            canvas.Children[child.CanvasChildIndex.Value] = child.VisualToken;
        }

        public static void MarkPlayerWithBall<T>(Canvas canvas, T child)
            where T : IDrawOnCanvas
        {
            if (child.CanvasChildIndex == null)
            {
                throw new Exception("Child does not have a valid CanvasIndex");
            }

            child.VisualToken.Fill = Brushes.DeepPink;
        }


        #region Private methods
        /// <summary>
        /// Update a child elements position in 
        /// relation to the canvas, based on the 
        /// cooridnates stored in that child.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="child"></param>
        private static void UpdateCanvasPositionCoordinates<T>(T child)
             where T : IDrawOnCanvas
        {
            // Get new Field Postion based on GridPosition
            var fieldRow = child.GridPosition.X;
            var fieldCol = child.GridPosition.Y;

            var newFieldPosition =
                PlayingFieldVisualizationSettings.GridCoordinates[fieldRow, fieldCol];

            child.FieldPosition = newFieldPosition;

            // Apply new position.
            Canvas.SetTop(child.VisualToken, child.FieldPosition.X);
            Canvas.SetLeft(child.VisualToken, child.FieldPosition.Y);
        }

        #endregion
    }
}
