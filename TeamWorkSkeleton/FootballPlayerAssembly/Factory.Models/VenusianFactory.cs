namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Species.NameGenerator;

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
            var newPlayer = new Roles.VenusianFootballPlayer.FootballPlayerFactory
                .VenusianAttacker(baseStats);
            newPlayer.Name = GetVenusianName();
            return newPlayer;
        }

        private static FootballPlayer CreateVenusianDefender
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayer = new Roles.VenusianFootballPlayer.FootballPlayerFactory
                .VenusianDefender(baseStats);
            newPlayer.Name = GetVenusianName();
            return newPlayer;
        }

        private static FootballPlayer CreateVenusianMidfielder
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayer = new Roles.VenusianFootballPlayer.FootballPlayerFactory
                .VenusianMidfielder(baseStats);
            newPlayer.Name = GetVenusianName();
            return newPlayer;
        }

        private static FootballPlayer CreateVenusianGoalkeeper
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayer = new Roles.VenusianFootballPlayer.FootballPlayerFactory
                .VenusianGoalkeeper(baseStats);
            newPlayer.Name = GetVenusianName();
            return newPlayer;
        }

        private static string GetVenusianName()
        {
            return VenusianNameGenerator.GenerateName();
        }
    }
}
