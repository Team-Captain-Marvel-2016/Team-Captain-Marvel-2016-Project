namespace VisualizationInterfacesAssembly.CanvasVisualizationInterfaces
{
    using GlobalDataStructures;
    using System.Windows.Shapes;

    public interface IDrawOnCanvas
    {
        PositionXY FieldPosition { get; set; }
        PositionXY GridPosition { get; set; }
        Ellipse VisualToken { get; set; }
        int? CanvasChildIndex { get; set; }
    }
}