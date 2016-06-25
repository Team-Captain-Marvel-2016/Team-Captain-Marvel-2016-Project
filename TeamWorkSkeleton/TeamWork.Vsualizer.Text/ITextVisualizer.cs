namespace TeamWork.Vsualizer.Text
{
    using System.Text;

    public interface ITextVisualizer
    {
        void Display(string format, params string[] args);

        void Display(string message);

        void Display(StringBuilder message);

        void AddFormat(string format);
    }
}