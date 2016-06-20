namespace FootballPlayerAssembly.SpeciesNameGenerators
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class MartianNameGenerator
    {

        internal static Dictionary<int, string> FirstPartName = new Dictionary<int, string>()
        {
            { 0 , "Ore" },
            { 1 , "Eden" },
            { 2 , "Libby" },
            { 3 , "Proctor" },
            { 4 , "Triad" },
            { 5 , "Jeddak" },
            { 6 , "Warhoom" },
            { 7 , "Dejah" },
            { 8 , "Dwar" },
            { 9 , "Primac" }
        };

        internal static Dictionary<int, string> LastPartName = new Dictionary<int, string>()
        {
            { 0 , "Heaven" },
            { 1 , "Kan" },
            { 2 , "Eclipse" },
            { 3 , "Mooner" },
            { 4 , "Blastic" },
            { 5 , "Telenor" },
            { 6 , "Gravyton" },
            { 7 , "Crypton" },
            { 8 , "Kinetic" },
            { 9 , "Odwar" }
        };

        internal static string GenerateName()
        {
            var random = new Random();
            var sb = new StringBuilder();
            sb.Append(FirstPartName[random.Next(0, 9)]);
            sb.Append(LastPartName[random.Next(0, 9)]);

            return sb.ToString();
        }
    }
}


