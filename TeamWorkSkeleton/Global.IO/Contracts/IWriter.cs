namespace Global.IO.Contracts
{
    using System.Collections.Generic;

    public interface IWriter 
    {
        void Write<T>(IEnumerable<T> collection);
    }
}