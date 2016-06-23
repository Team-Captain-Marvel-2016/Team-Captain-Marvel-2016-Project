namespace TeamWork.Models.Factory.Models
{
    using Spcies.NameGenerator;
    using FootballPlayer = Abstract.FootballPlayer;

    public static partial class FootballPlayerFactory
    {
        /// <summary>
        /// Creates a new Venusian player object 
        /// applying previously generated set of base 
        /// FootballPlayer base abstract stats
        /// wrapped in a GenericFootballPlayer object
        /// </summary>
        /// <param name="baseStats"> 
        /// set of stats wrapped in a GenericFootballPlayer object 
        /// </param>
        /// <returns>new Venusian(Position) object</returns>
        private static FootballPlayer CreateVenusianAttacker
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
           var newPlayerName = GetVenusianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.VenusianFootballPlayer.FootballPlayerFactory
                .VenusianAttacker(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateVenusianDefender
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetVenusianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.VenusianFootballPlayer.FootballPlayerFactory
                .VenusianDefender(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateVenusianMidfielder
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetVenusianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.VenusianFootballPlayer.FootballPlayerFactory
                .VenusianMidfielder(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateVenusianGoalkeeper
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetVenusianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.VenusianFootballPlayer.FootballPlayerFactory
                .VenusianGoalkeeper(baseStats);
            return newPlayer;
        }

        private static string GetVenusianName()
        {
            return VenusianNameGenerator.GenerateName();
        }
    }
}
