namespace FootballPlayerAssembly.FootballPlayerFactoryClasses
{
    using FootballPlayerAbstractClass;
    using SpeciesNameGenerators;

    public static partial class FootballPlayerFactory
    {
        /// <summary>
        /// Creates a new Jupiterian player object 
        /// applying previously generated set of base 
        /// FootballPlayer base abstract stats
        /// wrapped in a GenericFootballPlayer object
        /// </summary>
        /// <param name="baseStats"> 
        /// set of stats wrapped in a GenericFootballPlayer object 
        /// </param>
        /// <returns>new Jupiterian(Position) object</returns>
        private static FootballPlayer CreateJupiterianAttacker
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetJupiterianName();
            var newPlayer = new RolesClasses.JupiterianFootballPlayer.FootballPlayerFactory
                .JupiterianAttacker(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateJupiterianDefender
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetJupiterianName();
            var newPlayer = new RolesClasses.JupiterianFootballPlayer.FootballPlayerFactory
                .JupiterianDefender(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateJupiterianMidfielder
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetJupiterianName();
            var newPlayer = new RolesClasses.JupiterianFootballPlayer.FootballPlayerFactory
                .JupiterianMidfielder(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateJupiterianGoalkeeper
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetJupiterianName();
            var newPlayer = new RolesClasses.JupiterianFootballPlayer.FootballPlayerFactory
                .JupiterianGoalkeeper(baseStats);
            return newPlayer;
        }

        private static string GetJupiterianName()
        {
            return JupiterianNameGenerator.GenerateName();
        }
    }
}
