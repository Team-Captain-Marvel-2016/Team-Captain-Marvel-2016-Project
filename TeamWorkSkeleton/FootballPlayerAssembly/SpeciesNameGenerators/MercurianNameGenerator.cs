namespace FootballPlayerAssembly.SpeciesNameGenerators
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal static class MercurianNameGenerator
    {
        internal static Dictionary<int, string> FirstName = new Dictionary<int, string>()
        {
            {0, "meke"},
            {1, "keke"},
            {2, "veke"},
            {3, "deke"},
            {4, "reke"},
            {5, "leke"},
            {6, "okke"},
            {7, "boke"},
            {8, "poke"},
            {9, "voke"}
        };
        internal static Dictionary<int, string> LastName = new Dictionary<int, string>()
        {
            {0, "doko"},
            {1, "boko"},
            {2, "roko"},
            {3, "moko"},
            {4, "koko"},
            {5, "foko"},
            {6, "poko"},
            {7, "goko"},
            {8, "zoko"},
            {9, "loko"}
        };

        internal static string GenerateName()
        {
            var random = new Random();
            var sb = new StringBuilder();
            sb.Append(FirstName[random.Next(0, 9)]);
            sb.Append(LastName[random.Next(0, 9)]);
            return sb.ToString();
        }
    }
}
