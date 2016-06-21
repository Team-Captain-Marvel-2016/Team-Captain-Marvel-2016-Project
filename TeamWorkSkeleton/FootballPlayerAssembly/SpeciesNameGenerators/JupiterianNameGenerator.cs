namespace FootballPlayerAssembly.SpeciesNameGenerators
{
    using RandomizersAssembly.StaticRandomizersClasses;
    using System.Collections.Generic;
    using System.Text;

    internal static class JupiterianNameGenerator
    {
        internal static Dictionary<int, string> FirstPartName = new Dictionary<int, string>()
        {
            { 0 , "Zen" },
            { 1 , "Feng" },
            { 2 , "Lani" },
            { 3 , "Jupy" },
            { 4 , "Solar" },
            { 5 , "Gor" },
            { 6 , "Adebal" },
            { 7 , "Punto" },
            { 8 , "Exotus" },
            { 9 , "Wort" }
        };

        internal static Dictionary<int, string> LastPartName = new Dictionary<int, string>()
        {
            { 0 , "Spacer" },
            { 1 , "Lightning" },
            { 2 , "Razor" },
            { 3 , "Cryptonic" },
            { 4 , "Qwarz" },
            { 5 , "Wum" },
            { 6 , "Echo" },
            { 7 , "Drandel" },
            { 8 , "Limp" },
            { 9 , "Jumper" }
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
