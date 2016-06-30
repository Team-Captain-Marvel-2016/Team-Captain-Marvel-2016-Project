namespace Global.IO.Contracts
{
    using System.Collections;

    public interface IWriter 
    {
        void Write(IEnumerable collection);
    }
}