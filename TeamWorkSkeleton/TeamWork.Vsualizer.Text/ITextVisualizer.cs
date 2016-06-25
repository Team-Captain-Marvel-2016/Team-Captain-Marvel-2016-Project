namespace TeamWork.Vsualizer.Text
{
    using System.Collections.Generic;
    using System.Text;

    public interface ITextVisualizer
    {
        void Display(string message);
        
        void Hide();

        void Show();

        void Clear();
    }
}