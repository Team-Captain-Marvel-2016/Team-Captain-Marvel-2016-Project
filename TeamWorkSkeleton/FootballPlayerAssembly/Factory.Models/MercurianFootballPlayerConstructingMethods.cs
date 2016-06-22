namespace TeamWork.Models.Factory.Models
{
    using FootballPlayerAssembly.SpeciesNameGenerators;
    using FootballPlayer = Abstract.FootballPlayer;

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
        private static FootballPlayer CreateMercurianAttacker
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMercurianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.MercurianFootballPlayer.FootballPlayerFactory
                .MercurianAttacker(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateMercurianDefender
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMercurianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.MercurianFootballPlayer.FootballPlayerFactory
                .MercurianDefender(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateMercurianMidfielder
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMercurianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.MercurianFootballPlayer.FootballPlayerFactory
                .MercurianMidfielder(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateMercurianGoalkeeper
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMercurianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.MercurianFootballPlayer.FootballPlayerFactory
                .MercurianGoalkeeper(baseStats);
            return newPlayer;
        }

        private static string GetMercurianName()
        {
            return MercurianNameGenerator.GenerateName();
        }
    }
}
