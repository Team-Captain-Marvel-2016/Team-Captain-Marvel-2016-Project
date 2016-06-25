namespace UI.Element.Manager.UIManager
{
    using Contracts;
    using Exception;
    using System.Collections;
    using System.Collections.Generic;
    using Validation;

    /// <summary>
    /// Manages a list of ButtonGroups.
    /// </summary>
    public class ElementManager : IEnumerable<IElementGroup>
    {
        private readonly List<IElementGroup> groups;
        private readonly List<string> groupNames;

        public ElementManager()
        {
            this.groups = new List<IElementGroup>();
            this.groupNames = new List<string>();
        }

        public IElementGroup this[int index]
        {
            get
            {
                if (Validate.IndexExists(index, this.groups))
                {
                    return this.groups[index];
                }
                else
                {
                    throw new ElementManagerException("Index out of range");
                }
            }
        }

        public IElementGroup this[string name]
        {
            get
            {
                if (Validate.ElementExists(name, this.groupNames))
                {
                    var index = this.groupNames.IndexOf(name);

                    return this.groups[index];
                }
                else
                {
                    throw new ElementManagerException("Element not found");
                }
            }
        }

        public void Add(IElementGroup group)
        {
            if (Validate.ElementExists(group.Name, this.groupNames))
            {
                throw new ElementManagerException
                    ("Element already exists");
            }

            this.groups.Add(group);
            this.groupNames.Add(group.Name);
        }

        public void Remove(IElementGroup group)
        {
            if (Validate.ElementExists(group.Name, this.groupNames))
            {
                this.Remove(group);
            }
            else
            {
                throw new ElementManagerException("Element not found");
            }
        }

        public void Enable()
        {
            foreach (var elementGroup in this.groups)
            {
                elementGroup.Enable();
            }
        }

        public void Disable()
        {
            foreach (var elementGroup in this.groups)
            {
                elementGroup.Disable();
            }
        }

        public void Display()
        {
            foreach (var elementGroup in this.groups)
            {
                elementGroup.Display();
            }
        }

        public void Hide()
        {
            foreach (var elementGroup in this.groups)
            {
                elementGroup.Hide();
            }
        }

        public IEnumerator<IElementGroup> GetEnumerator()
        {
            foreach (var group in this.groups)
            {
                yield return group;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
