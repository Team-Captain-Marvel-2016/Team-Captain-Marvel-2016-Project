namespace UI.Element.Manager.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class Validate
    {
        internal static bool ElementExists<T>(T element, ICollection<T> collection)
            where T : IComparable<T>
        {
            return (collection.Any(el => el.CompareTo(element) == 0));
        }

        internal static bool IndexExists<T>(int index, ICollection<T> collection)
        {
            return (0 <= index && index <= collection.Count - 1);
        }

        internal static bool ElementNull<T>(T element)
        {
            return element == null;
  ;      }
    }
}