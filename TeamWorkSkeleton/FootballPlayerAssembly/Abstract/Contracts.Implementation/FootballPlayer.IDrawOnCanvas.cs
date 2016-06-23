namespace TeamWork.Models.Abstract
{
    using Global.DataStructures;
    using System.Windows.Media;
    using System.Windows.Shapes;

    public abstract partial class FootballPlayer
    {
        private void InitVisualToken()
        {
            this.VisualToken = new Ellipse() { Width = 15, Height = 15 };
            this.GridPosition = new PositionXY();
            this.FieldPosition = new PositionXY();
        }

        public void SetVisualTokenColor(SolidColorBrush colorBrush)
        {
            this.VisualToken.Fill = colorBrush;
        }

        public void SetVisualTokenSize(int width, int height)
        {
            this.VisualToken.Width = width;
            this.VisualToken.Height = height;
        }
    }
}
