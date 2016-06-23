namespace Global.Contracts
{
    using System.Windows.Media;
    using System.Windows.Shapes;
    using DataStructures;

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