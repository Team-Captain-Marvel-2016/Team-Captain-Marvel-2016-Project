namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Global.Contracts;
    using Species.NameGenerator;

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
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.UranianFootballPlayer.FootballPlayerFactory
                .UranianAttacker(baseStats);
            newPlayer.Name = GetUranianName();
            return newPlayer;
        }

        private static FootballPlayer CreateUranianDefender
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.UranianFootballPlayer.FootballPlayerFactory
                .UranianDefender(baseStats);
            newPlayer.Name = GetUranianName();
            return newPlayer;
        }

        private static FootballPlayer CreateUranianMidfielder
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.UranianFootballPlayer.FootballPlayerFactory
                .UranianMidfielder(baseStats);
            newPlayer.Name = GetUranianName();
            return newPlayer;
        }

        private static FootballPlayer CreateUranianGoalkeeper
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.UranianFootballPlayer.FootballPlayerFactory
                .UranianGoalkeeper(baseStats);
            newPlayer.Name = GetUranianName();
            return newPlayer;
        }

        private static string GetUranianName()
        {
            return UranianNameGenerator.GenerateName();
        }
    }
}
