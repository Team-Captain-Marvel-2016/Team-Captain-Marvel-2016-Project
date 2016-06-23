namespace TeamWork.Models.Abstract
{
    using System.Windows.Media;

    public abstract partial class FootballPlayer
    {
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
