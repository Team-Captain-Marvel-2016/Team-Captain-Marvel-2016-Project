namespace Global.IO.Contracts
{
    using System.IO;

    public interface IFileIO
    {
        FileInfo File { get; }
    }
}