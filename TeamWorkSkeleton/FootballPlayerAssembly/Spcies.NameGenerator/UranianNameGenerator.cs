namespace TeamWork.Models.Spcies.NameGenerator
{
    using System.Collections.Generic;
    using System.Text;
    using Global.Randomization;

    internal static class UranianNameGenerator
    {
        private static readonly Dictionary<int, string> FirstPartName 
            = new Dictionary<int, string>()
        {
            { 0 , "" },
            { 1 , "" },
            { 2 , "" },
            { 3 , "" },
            { 4 , "" },
            { 5 , "" },
            { 6 , "" },
            { 7 , "" },
            { 8 , "" },
            { 9 , "" }
        };

        private static readonly Dictionary<int, string> LastPartName
            = new Dictionary<int, string>()
        {
            { 0 , "" },
            { 1 , "" },
            { 2 , "" },
            { 3 , "" },
            { 4 , "" },
            { 5 , "" },
            { 6 , "" },
            { 7 , "" },
            { 8 , "" },
            { 9 , "" }
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