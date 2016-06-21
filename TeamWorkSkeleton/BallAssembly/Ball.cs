namespace BallAssembly
{
    using System.Windows.Shapes;
    using GlobalDataStructures;
    using VisualizationInterfacesAssembly.CanvasVisualizationInterfaces;

    public class Ball : IDrawOnCanvas
    {
        public Ball(PositionXY gridPosition)
        {
            this.GridPosition = gridPosition;
        }

        public PositionXY FieldPosition { get; set; }
        public PositionXY GridPosition { get; set; }
        public Ellipse VisualToken { get; set; }
        public int? CanvasChildIndex { get; set; }
    }
}
