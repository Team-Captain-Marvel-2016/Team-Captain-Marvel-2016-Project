namespace UI.Element.Manager.UIManager
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using Exception;
    using Validation;

    public partial class ButtonGroup : IElementGroup
    {
        private readonly List<Button> buttons;
        private readonly List<string> buttonNames;

        public ButtonGroup(string name)
        {
            this.Name = name;
            this.buttons = new List<Button>();
            this.buttonNames = new List<string>();
        }

        public ButtonGroup(string name, params EventHandler[] events)
            : this(name)
        {
            this.SubscribeToEvents(events);
        }

        public string Name { get; private set; }

        public Button this[int index] => this.buttons[index];

        public Button this[string name]
        {
            get
            {
                var index = this.buttonNames.IndexOf(name);

                if (index < 0)
                {
                    throw new ArgumentException("Name not found");
                }

                return this.buttons[index];
            }
        }

        public void Add(object element)
        {
            var button = element as Button;

            try
            {
                Validate.ElementNull(button);
                Validate.ElementExists(button?.Name, this.buttonNames);
            }
            catch (ArgumentNullException e)
            {
                throw new ElementManagerException("", e);
            }
            catch (ArgumentException e)
            {
                throw new ElementManagerException("", e);
            }

            this.buttons.Add(button);
            this.buttonNames.Add(button?.Name);
        }

        public void Remove(int index)
        {
            if (index < 0 || this.buttons.Count <= index)
            {
                throw new IndexOutOfRangeException("Index Out Of Range");
            }

            this.buttons.RemoveAt(index);
            this.buttonNames.RemoveAt(index);
        }

        public void Remove(string name)
        {
            var index = this.buttonNames.IndexOf(name);

            if (index < 0)
            {
                throw new ArgumentException("Name not found");
            }

            this.Remove(index);
        }

        public void Display()
        {
            foreach (var button in this.buttons)
            {
                button.Visibility = Visibility.Visible;
            }
        }

        public void Hide()
        {
            foreach (var button in this.buttons)
            {
                button.Visibility = Visibility.Collapsed;
            }
        }

        public void Enable()
        {
            foreach (var button in this.buttons)
            {
                button.IsEnabled = true;
            }
        }

        public void Disable()
        {
            foreach (var button in this.buttons)
            {
                button.IsEnabled = false;
            }
        }
    }
}
