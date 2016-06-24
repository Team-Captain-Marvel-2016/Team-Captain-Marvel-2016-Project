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
            if (collection.Any(el => el.CompareTo(element) == 0))
            {
                throw new ArgumentException();
            }

            return false;
        }

        internal static bool ElementNull<T>(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException();
            }

            return false;
        }
    }
}