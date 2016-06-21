namespace FootballPlayerAssembly.SpeciesNameGenerators
{
    using RandomizersAssembly.StaticRandomizersClasses;
    using System.Collections.Generic;
    using System.Text;

    internal static class SagittariusianNameGenerator
    {
        internal static Dictionary<int, string> FirstName = new Dictionary<int, string>()
        {
            {0,"Azog" },
            {1,"Rolo" },
            {2,"Gimli" },
            {3,"Ragnar" },
            {4,"Larz" },
            {5,"Zerg" },
            {6,"Raok" },
            {7,"Brohle" },
            {8,"Rovis" },
            {9,"Vorg" },
        };

        internal static Dictionary<int, string> LastName = new Dictionary<int, string>()
        {
            {0,"Rovels" },
            {1,"Sagian" },
            {2,"Vengian" },
            {3,"Rosemin" },
            {4,"Faramies" },
            {5,"Raopes" },
            {6,"Hellin" },
            {7,"Brolin" },
            {8,"Kremoles" },
            {9,"Brinis" },
        };

        internal static string NameGenerator()
        {
            var random = GenericRandomization.Random;
            var names = new StringBuilder();
            names.Append(FirstName[random.Next(0, 9)]);
            names.Append(LastName[random.Next(0, 9)]);
            return names.ToString();

        }
    }
}
