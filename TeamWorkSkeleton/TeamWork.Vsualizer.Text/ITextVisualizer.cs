namespace TeamWork.Vsualizer.Text
{
    public interface ITextVisualizer
    {
        void Display(string message);
        
        void Hide();

        void Show();

        void Clear();
    }
}