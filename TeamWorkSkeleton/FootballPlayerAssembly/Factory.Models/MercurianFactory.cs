namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Species.NameGenerator;

    public static partial class FootballPlayerFactory
    {
        /// <summary>
        /// Creates a new Mercurian player object 
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
            var newPlayer = new Roles.MercurianFootballPlayer.FootballPlayerFactory
                .MercurianAttacker(baseStats);
            newPlayer.Name = GetMercurianName();
            return newPlayer;
        }

        private static FootballPlayer CreateMercurianDefender
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayer = new Roles.MercurianFootballPlayer.FootballPlayerFactory
                .MercurianDefender(baseStats);
            newPlayer.Name = GetMercurianName();
            return newPlayer;
        }

        private static FootballPlayer CreateMercurianMidfielder
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayer = new Roles.MercurianFootballPlayer.FootballPlayerFactory
                .MercurianMidfielder(baseStats);
            newPlayer.Name = GetMercurianName();
            return newPlayer;
        }

        private static FootballPlayer CreateMercurianGoalkeeper
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayer = new Roles.MercurianFootballPlayer.FootballPlayerFactory
                .MercurianGoalkeeper(baseStats);
            newPlayer.Name = GetMercurianName();
            return newPlayer;
        }

        private static string GetMercurianName()
        {
            return MercurianNameGenerator.GenerateName();
        }
    }
}
