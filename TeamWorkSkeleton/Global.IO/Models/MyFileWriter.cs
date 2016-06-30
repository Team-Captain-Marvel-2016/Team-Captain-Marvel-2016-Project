namespace Global.IO.Models
{
    using System.Collections;
    using System.IO;
    using System.Text;

    using Contracts;

    public sealed class MyFileWriter : FileIO, IWriter
    {
        public MyFileWriter(FileInfo file)
            : base(file)
        {
        }

        /// <summary>
        /// Writes a collection to a file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        public void Write(IEnumerable collection)
        {
            var stream = new FileStream(
                this.File.FullName, 
                FileMode.OpenOrCreate, 
                FileAccess.Write, 
                FileShare.Read);

            using (var writer = new StreamWriter(stream, Encoding.UTF8))
            {
                foreach (var el in collection)
                {
                    writer.WriteLine(el.ToString());
                }

                writer.Close();
            }
        }
    }
}
