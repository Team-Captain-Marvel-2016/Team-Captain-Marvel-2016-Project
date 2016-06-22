namespace TeamWork.Models.Factory.Models
{
    using FootballPlayerAssembly.SpeciesNameGenerators;
    using FootballPlayer = Abstract.FootballPlayer;

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
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetUranianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.UranianFootballPlayer.FootballPlayerFactory
                .UranianAttacker(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateUranianDefender
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetUranianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.UranianFootballPlayer.FootballPlayerFactory
                .UranianDefender(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateUranianMidfielder
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetUranianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.UranianFootballPlayer.FootballPlayerFactory
                .UranianMidfielder(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateUranianGoalkeeper
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetUranianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.UranianFootballPlayer.FootballPlayerFactory
                .UranianGoalkeeper(baseStats);
            return newPlayer;
        }

        private static string GetUranianName()
        {
            return UranianNameGenerator.GenerateName();
        }
    }
}
