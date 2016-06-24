namespace TeamWork.Models.Species.NameGenerator
{
    using Global.Randomization;
    using System.Collections.Generic;
    using System.Text;

    internal static class UranianNameGenerator
    {

        private static readonly Dictionary<int, string> FirstPartName 
            = new Dictionary<int, string>()
        {
            { 0 , "Ari" },
            { 1 , "Mani" },
            { 2 , "Kani" },
            { 3 , "Lupi" },
            { 4 , "Hera" },
            { 5 , "Koni" },
            { 6 , "Xika" },
            { 7 , "Fylo" },
            { 8 , "Poli" },
            { 9 , "Enga" }
        };

        private static readonly Dictionary<int, string> LastPartName
            = new Dictionary<int, string>()
        {
            { 0 , "buro" },
            { 1 , "mypo" },
            { 2 , "typo" },
            { 3 , "fyto" },
            { 4 , "xuro" },
            { 5 , "kopy" },
            { 6 , "tyto" },
            { 7 , "wypo" },
            { 8 , "neto" },
            { 9 , "vybo" }
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