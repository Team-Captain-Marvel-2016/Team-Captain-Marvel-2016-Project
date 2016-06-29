namespace Global.IO.Models
{
    using System.IO;
    using Contracts;

    using Validation;

    public abstract class FileIO : IFileIO
    {
        private FileInfo file;

        protected FileIO(FileInfo file)
        {
            this.File = file;
        }

        public FileInfo File
        {
            get
            {
                return this.file;
            }
            private set
            {
                Validator.CheckIfObjectIsNull(
                    value,
                    string.Format(
                        ErrorMessages.IsNull,
                        nameof(this.File)));

                Validator.CheckIfFileExists(
                    value,
                    string.Format(
                        ErrorMessages.FileNotFound,
                        value.FullName));

                this.file = value;
            }
        }

        public void SetFile(FileInfo file)
        {
            this.File = file;
        }
    }
}
