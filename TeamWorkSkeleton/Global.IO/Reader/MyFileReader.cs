namespace Global.IO.Reader
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;

    using Contracts;

    public class MyFileReader : IReader, IFileIO
    {
        private FileInfo file;

        public MyFileReader(FileInfo file)
        {
            this.File = file;
        }

        public FileInfo File {
            get
            {
                return this.file;
            }
            private set
            {
                // TODO:
                // Check null
                // Check exists
                this.file = value;
            }
        }

        public ICollection<string> Read()
        {
            var output = new Collection<string>();

            using (var reader = new StreamReader(this.File.FullName))
            {
                while (!reader.EndOfStream)
                {
                    output.Add(reader.ReadLine());
                }

                reader.Close();
            }

            return output;
        }

        public void SetFileName(FileInfo file)
        {
            this.File = file;
        }
    }
}
