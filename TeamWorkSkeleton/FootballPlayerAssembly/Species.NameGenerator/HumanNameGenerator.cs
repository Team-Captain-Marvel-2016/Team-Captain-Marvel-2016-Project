namespace TeamWork.Models.Species.NameGenerator
{
    using System.Collections.Generic;
    using System.Text;
    using Global.Randomization;

    internal class HumanNameGenerator
    {
        private static readonly Dictionary<int, string> FirstPartName = 
            new Dictionary<int, string>()
        {
            { 0 , "David" },
            { 1 , "Gareth" },
            { 2 , "James" },
            { 3 , "Gabriel" },
            { 4 , "Peter" },
            { 5 , "Antonio" },
            { 6 , "Michael" },
            { 7 , "Steven" },
            { 8 , "Chris" },
            { 9 , "Thomas" }
        };

        private static readonly Dictionary<int, string> LastPartName =
            new Dictionary<int, string>()
        {
            { 0 , "O'Neil" },
            { 1 , "Larson" },
            { 2 , "Jerard" },
            { 3 , "Muller" },
            { 4 , "Demichelis" },
            { 5 , "Bierhoff" },
            { 6 , "Martins" },
            { 7 , "Sutton" },
            { 8 , "Lampard" },
            { 9 , "Akinfeev" }
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
