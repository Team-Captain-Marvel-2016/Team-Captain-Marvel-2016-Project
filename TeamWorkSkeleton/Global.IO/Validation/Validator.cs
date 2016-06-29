namespace Global.IO.Validation
{
    using System;
    using System.IO;

    internal static class Validator
    {
        internal static void CheckIfObjectIsNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw  new ArgumentNullException(message);
            }
        }

        internal static void CheckIfFileExists(FileInfo file, string message = null)
        {
            if (!file.Exists)
            {
                throw new FileNotFoundException(message);
            }
        }
    }
}
