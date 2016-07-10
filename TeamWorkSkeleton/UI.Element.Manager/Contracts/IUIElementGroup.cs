namespace UI.Element.Manager.Contracts
{
    using System;

    public interface IElementGroup : IComparable<IElementGroup>
    {
        string Name { get; }

        int ContainerSize { get; }

        void Add(object obj);

        void Remove(int index);

        void Display();

        void Hide();

        void Enable();

        void Disable();

        void SubscribeEnable(ref EventHandler ev);

        void SubscribeDisable(ref EventHandler ev);

        void SubscribeDisplay(ref EventHandler ev);

        void SubscribeHide(ref EventHandler ev);

        void UnsubscribeEnable(ref EventHandler ev);

        void UnsubscribeDisable(ref EventHandler ev);

        void UnsubscribeDisplay(ref EventHandler ev);

        void UnsubscribeHide(ref EventHandler ev);
    }
}