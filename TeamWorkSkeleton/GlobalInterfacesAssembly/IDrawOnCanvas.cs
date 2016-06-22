namespace Global.Contracts
{
    using System.Windows.Shapes;
    using DataStructures;

    public interface IDrawOnCanvas
    {
        PositionXY FieldPosition { get; set; }
        PositionXY GridPosition { get; set; }
        Ellipse VisualToken { get; set; }
        int? CanvasChildIndex { get; set; }
    }
}