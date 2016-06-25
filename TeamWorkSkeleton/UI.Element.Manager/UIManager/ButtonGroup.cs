namespace UI.Element.Manager.UIManager
{
    using Contracts;
    using Exception;
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using Validation;

    /// <summary>
    /// Creates a group of buttons.
    /// Overloads indexers to be able to access a button by name.
    /// Methods for displaying and hiding.
    /// </summary>
    public partial class ButtonGroup : IElementGroup, IComparable<ButtonGroup>
    {
        private readonly List<Button> buttons;
        private readonly List<string> buttonNames;

        private string myName;

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

        public string Name
        {
            get
            {
                return this.myName;
            }
            private set
            {
                if (Validate.ElementNull(value))
                {
                    throw new ElementManagerException("Name is Empty");
                }
                else
                {
                    this.myName = value;
                }
            }
        }

        public int ContainerSize => this.buttons.Count;
        
        public Button this[int index]
        {
            get
            {
                if (Validate.IndexExists(index, this.buttons))
                {
                    return this.buttons[index];
                }
                else
                {
                    throw new ElementManagerException("Index out of range");
                }
            }
        }

        public Button this[string name]
        {
            get
            {
                if (Validate.ElementExists(name, this.buttonNames))
                {
                    var index = this.buttonNames.IndexOf(name);

                    return this.buttons[index];
                }
                else
                {
                    throw new ElementManagerException("Element not found");
                }
            }
        }

        public void Add(object element)
        {
            var button = element as Button;

            if (button == null)
            {
                throw new ElementManagerException
                    ("Incorrect input object type");
            }

            if (Validate.ElementExists(button.Name, this.buttonNames))
            {
                throw new ElementManagerException
                    ("Element already exists");
            }

            this.buttons.Add(button);
            this.buttonNames.Add(button?.Name);
        }

        public void Remove(int index)
        {
            if (!Validate.IndexExists(index, this.buttons))
            {
                throw new ElementManagerException
                    ("Invalid index");
            }

            this.buttons.RemoveAt(index);
            this.buttonNames.RemoveAt(index);
        }

        public void Remove(string name)
        {
            if (Validate.ElementExists(name, this.buttonNames))
            {
                var index = this.buttonNames.IndexOf(name);

                this.Remove(index);
            }
            else
            {
                throw new ElementManagerException("Element not found");
            }
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

        public int CompareTo(ButtonGroup other)
        {
            return this.CompareTo(other as IElementGroup);
        }
        
        public int CompareTo(IElementGroup other)
        {
            return this.ContainerSize - other.ContainerSize;
        }
    }
}
