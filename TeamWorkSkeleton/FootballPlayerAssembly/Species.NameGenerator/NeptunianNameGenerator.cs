namespace TeamWork.Models.Species.NameGenerator
{
    using System;
    using System.Collections.ObjectModel;
    using System.IO;
    using Global.IO.Models;
    using Global.Randomization;
    using System.Collections;
    using System.Collections.Generic;
    internal static class NeptunianNameGenerator
    {
        private const string FileName = ".\\txt-assets\\neptunian-names.txt";
        private const string OutputFormat = "$({0}#{1})";
        private const int LengthInNames = 2;

        internal static string GenerateName()
        {
            // http://wiki.postfurry.net/wiki/Neptunian_language
            // Get List of nouns from file
            var names = GetDataFromFile();

            // Get bounds for random generator
            var bound = names.Count;

            // Create a list to fill
            var namesToAdd = new Collection<string>();

            for (int i = 0; i < LengthInNames; i++)
            {
                namesToAdd.Add(
                    names[GenericRandomization.Random.Next(0, bound - 1)]);
            }

            return String.Format(
                OutputFormat,
                namesToAdd[0],
                namesToAdd[1]);
        }

        private static IList<string> GetDataFromFile()
        {
            var file = new FileInfo(FileName);
            var myReader = new MyFileReader(file);

            return myReader.Read();
        }
    }
}
