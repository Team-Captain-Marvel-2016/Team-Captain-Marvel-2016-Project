namespace StartUpWPF
{
    using System.Windows.Controls;
    using TeamWork.Vsualizer.Text;

    public partial class MainWindow
    {
        private void InitializeTextBlockVisualizer(TextBlock textBlock)
        {
            this.TextBlockVisualizer = new TextBlockVisualizer(textBlock);
        }
    }
}