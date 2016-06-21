namespace FootballPlayerAssembly.FootballPlayerFactoryClasses
{
    using FootballPlayerAbstractClass;
    using SpeciesNameGenerators;

    public static partial class FootballPlayerFactory
    {
        /// <summary>
        /// Creates a new Uranian player object 
        /// applying previously generated set of base 
        /// FootballPlayer base abstract stats
        /// wrapped in a GenericFootballPlayer object
        /// </summary>
        /// <param name="baseStats"> 
        /// set of stats wrapped in a GenericFootballPlayer object 
        /// </param>
        /// <returns>new Uranian(Position) object</returns>
        private static FootballPlayer CreateUranianAttacker
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetUranianName();
            var newPlayer = new RolesClasses.UranianFootballPlayer.FootballPlayerFactory
                .UranianAttacker(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateUranianDefender
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetUranianName();
            var newPlayer = new RolesClasses.UranianFootballPlayer.FootballPlayerFactory
                .UranianDefender(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateUranianMidfielder
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetUranianName();
            var newPlayer = new RolesClasses.UranianFootballPlayer.FootballPlayerFactory
                .UranianMidfielder(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateUranianGoalkeeper
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetUranianName();
            var newPlayer = new RolesClasses.UranianFootballPlayer.FootballPlayerFactory
                .UranianGoalkeeper(baseStats);
            return newPlayer;
        }

        private static string GetUranianName()
        {
            return UranianNameGenerator.GenerateName();
        }
    }
}
