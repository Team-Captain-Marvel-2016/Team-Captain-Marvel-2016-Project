namespace FootballPlayerAssembly.FootballPlayerFactoryClasses
{
    using FootballPlayerAbstractClass;
    using SpeciesNameGenerators;

    public static partial class FootballPlayerFactory
    {
        /// <summary>
        /// Creates a new Neptunian player object 
        /// applying previously generated set of base 
        /// FootballPlayer base abstract stats
        /// wrapped in a GenericFootballPlayer object
        /// </summary>
        /// <param name="baseStats"> 
        /// set of stats wrapped in a GenericFootballPlayer object 
        /// </param>
        /// <returns>new Neptunian(Position) object</returns>
        private static FootballPlayer CreateNeptunianAttacker
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetNeptunianName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianAttacker(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianDefender
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetNeptunianName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianDefender(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianMidfielder
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetNeptunianName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianMidfielder(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianGoalkeeper
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetNeptunianName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianGoalkeeper(baseStats);
            return newPlayer;
        }

        private static string GetNeptunianName()
        {
            return NeptunianNameGenerator.GenerateName();
        }
    }
}
