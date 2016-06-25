namespace Global.Contracts
{
    using System.Windows.Media;
    using System.Windows.Shapes;
    using DataStructures;

    /// <summary>
    /// Each object drawn on the canvas must have these properties and methods.
    /// Grid Postion (matrix) , FieldPostion in Pixels for drawing.
    /// Methods for setting token size and color.
    /// </summary>
    public interface IDrawOnCanvas
    {
        PositionXY FieldPosition { get; set; }
        PositionXY GridPosition { get; set; }
        Ellipse VisualToken { get; set; }
        int? CanvasChildIndex { get; set; }

        void SetVisualTokenColor(SolidColorBrush colorBrush);
        void SetVisualTokenSize(int width, int height);
    }
}