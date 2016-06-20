namespace FootballPlayerAssembly.FootballPlayerFactoryClasses
{
    using FootballPlayerAbstractClass;
    using SpeciesNameGenerators;

    public static partial class FootballPlayerFactory
    {
        /// <summary>
        /// Creates a new Human player object 
        /// applying previously generated set of base 
        /// FootballPlayer base abstract stats
        /// wrapped in a GenericFootballPlayer object
        /// </summary>
        /// <param name="baseStats"> 
        /// set of stats wrapped in a GenericFootballPlayer object 
        /// </param>
        /// <returns>new Martian(Position) object</returns>
        private static FootballPlayer CreateMartianAttacker
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMartianName();
            var newPlayer = new RolesClasses.MartianFootballPlayer.FootballPlayerFactory
                .MartianAttacker(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateMartianDefender
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMartianName();
            var newPlayer = new RolesClasses.MartianFootballPlayer.FootballPlayerFactory
                .MartianDefender(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateMartianMidfielder
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMartianName();
            var newPlayer = new RolesClasses.MartianFootballPlayer.FootballPlayerFactory
                .MartianMidfielder(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateMartianGoalkeeper
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMartianName();
            var newPlayer = new RolesClasses.MartianFootballPlayer.FootballPlayerFactory
                .MartianGoalkeeper(baseStats);
            return newPlayer;
        }

        private static string GetMartianName()
        {
            return MartianNameGenerator.GenerateName();
        }
    }
}
