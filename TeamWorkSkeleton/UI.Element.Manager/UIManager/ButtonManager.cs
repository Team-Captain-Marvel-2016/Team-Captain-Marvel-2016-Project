namespace UI.Element.Manager.UIManager
{
    using System;
    using System.Collections.Generic;
    using Contracts;

    public class ElementManager
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
                if (index < 0 || this.groups.Count <= index)
                {
                    throw new IndexOutOfRangeException("Trying to access an unexisting button group");
                }
                return this.groups[index];
            }
        }

        public IElementGroup this[string name]
        {
            get
            {
                var index = this.groupNames.IndexOf(name);

                if (index < 0)
                {
                    throw new ArgumentException("Element with this name does not exist");
                }

                return this.groups[index];
            }
        }

        public void Add(IElementGroup group)
        {
            this.groups.Add(group);
            this.groupNames.Add(group.Name);
        }

        public void Remove(IElementGroup group)
        {
            var index = this.groups.IndexOf(group);

            if (index < 0)
            {
                throw new ArgumentException("Group does not exist");
            }

            this.groups.RemoveAt(index);
        }
    }
}
