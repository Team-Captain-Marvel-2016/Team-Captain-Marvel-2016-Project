namespace TeamWork.Vsualizer.Text
{
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Controls;

    public sealed class TextBlockVisualizer : ITextVisualizer
    {
        private readonly TextBlock textBlock;

        public TextBlockVisualizer(TextBlock textBlock)
        {
            this.textBlock = textBlock;
        }

        public void Display<T>(string format, ICollection<T> collection)
        {
            throw new System.NotImplementedException();
        }

        public void Display(string message)
        {
            this.textBlock.Text = message;
        }

        public void Display(StringBuilder message)
        {
            throw new System.NotImplementedException();
        }

        public void Display(object obj)
        {
            throw new System.NotImplementedException();
        }

        public void AddFormat(string format)
        {
            throw new System.NotImplementedException();
        }
    }
}