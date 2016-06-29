namespace Global.IO.Models
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;

    using Contracts;

    public sealed class MyFileReader : FileIO, IReader
    {
        public MyFileReader(FileInfo file)
            : base(file)
        {
        }

        /// <summary>
        /// Reads File Contents to a Collection
        /// </summary>
        /// <returns></returns>
        public ICollection<string> Read()
        {
            var output = new Collection<string>();

            using (var reader = this.File.OpenText())
            {
                while (!reader.EndOfStream)
                {
                    output.Add(reader.ReadLine());
                }

                reader.Close();
            }

            return output;
        }
    }
}
