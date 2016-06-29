namespace TeamWork.Models.Species.NameGenerator
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Global.IO.Models;
    using Global.Randomization;


    internal static class NeptunianNameGenerator
    {
        private const string FileName = ".\\txt-assets\\neptunian-names.txt";
        private const string OutputFormat = "$({0}#{1})";
        private const int LengthInNames = 2;

        internal static string GenerateName()
        {
            // http://wiki.postfurry.net/wiki/Neptunian_language
            // Get List of nouns from file
            var file = new FileInfo(FileName);
            var myReader = new MyFileReader(file);
            var names = myReader.Read();

            // Get bounds for random generator
            var bound = names.Count;

            // Create a list to fill
            var namesToAdd = new List<string>();

            for (int i = 0; i < LengthInNames; i++)
            {
                namesToAdd.Add(names
                        .Skip(GenericRandomization.Random.Next(0, bound - 1))
                        .Take(1).First());
            }

            return String.Format(
                OutputFormat,
                namesToAdd[0],
                namesToAdd[1]);
        }
    }
}
