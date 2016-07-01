namespace UI.Element.Manager.Contracts
{
    using System;
    using System.Collections.Generic;

    internal interface IValidate
    {
        bool ElementExists<T>(T element, ICollection<T> collection)
            where T : IComparable<T>;

        bool IndexExists<T>(int index, ICollection<T> collection);
        bool ElementNull(object element);
    }
}