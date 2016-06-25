namespace TeamWork.Vsualizer.Text
{
    using System.Collections.Generic;
    using System.Text;

    public interface ITextVisualizer
    {
        void Display<T>(string format, ICollection<T> collection);

        void Display(string message);

        void Display(StringBuilder message);

        void Display(object obj);

        void AddFormat(string format);
    }
}