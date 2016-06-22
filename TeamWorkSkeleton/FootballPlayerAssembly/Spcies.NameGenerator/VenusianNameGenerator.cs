namespace FootballPlayerAssembly.SpeciesNameGenerators
{
    using RandomizersAssembly.StaticRandomizersClasses;
    using System.Collections.Generic;
    using System.Text;

    internal static class VenusianNameGenerator
    {
        internal static Dictionary<int, string> FirstPartName = new Dictionary<int, string>()
        {
            { 0 , "Mia" },
            { 1 , "Riu" },
            { 2 , "Khana" },
            { 3 , "Pury" },
            { 4 , "Erikq" },
            { 5 , "Sey" },
            { 6 , "Edo" },
            { 7 , "Livo" },
            { 8 , "Xipi" },
            { 9 , "Kai" }
        };

        internal static Dictionary<int, string> LastPartName = new Dictionary<int, string>()
        {
            { 0 , "vin" },
            { 1 , "margion" },
            { 2 , "philq" },
            { 3 , "neuron" },
            { 4 , "kakud" },
            { 5 , "novese" },
            { 6 , "muril" },
            { 7 , "fyfy" },
            { 8 , "diansin" },
            { 9 , "purl" }
        };

        internal static string GenerateName()
        {
            var random = GenericRandomization.Random;
            var sb = new StringBuilder();
            sb.Append(FirstPartName[random.Next(0, 9)]);
            sb.Append(LastPartName[random.Next(0, 9)]);

            return sb.ToString();
        }
    }
}