namespace UI.Element.Manager.Contracts
{
    public interface IElementManager
    {
        IElementGroup this[int index] { get; }

        IElementGroup this[string name] { get; }

        void Add(IElementGroup group);

        void Remove(IElementGroup group);

        void Enable();

        void Disable();

        void Display();

        void Hide();
    }
}