namespace UI.Element.Manager.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;

    internal class Validate : IValidate
    {
        public bool ElementExists<T>(T element, ICollection<T> collection)
            where T : IComparable<T>
        {
            return (collection.Any(el => el.CompareTo(element) == 0));
        }

        public bool IndexExists<T>(int index, ICollection<T> collection)
        {
            return (0 <= index && index <= collection.Count - 1);
        }

        public bool ElementNull(object element)
        {
            return element == null;
        }
    }
}