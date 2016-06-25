namespace TeamWork.Vsualizer.Text
{
    using System.Windows;
    using System.Windows.Controls;

    public sealed class TextBlockVisualizer : ITextVisualizer
    {
        private readonly TextBlock textBlock;

        public TextBlockVisualizer(TextBlock textBlock)
        {
            this.textBlock = textBlock;
        }

        public void Display(string message)
        {
            this.textBlock.Text = message;
        }

        public void Hide()
        {
            this.textBlock.Visibility = Visibility.Collapsed;
        }

        public void Show()
        {
            this.textBlock.Visibility = Visibility.Visible;
        }

        public void Clear()
        {
            this.textBlock.Text = string.Empty;
        }
    }
}