namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Global.Contracts;
    using Species.NameGenerator;

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
        /// <returns>new Human(Position) object</returns>
        private static FootballPlayer CreateHumanAttacker
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.HumanFootballPlayer.FootballPlayerFactory
                .HumanAttacker(baseStats);
            newPlayer.Name = GetHumanName();
            return newPlayer;
        }

        private static FootballPlayer CreateHumanDefender
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.HumanFootballPlayer.FootballPlayerFactory
                .HumanDefender(baseStats);
            newPlayer.Name = GetHumanName();
            return newPlayer;
        }

        private static FootballPlayer CreateHumanMidfielder
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.HumanFootballPlayer.FootballPlayerFactory
                .HumanMidfielder(baseStats);
            newPlayer.Name = GetHumanName();
            return newPlayer;
        }

        private static FootballPlayer CreateHumanGoalkeeper
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.HumanFootballPlayer.FootballPlayerFactory
                .HumanGoalkeeper(baseStats);
            newPlayer.Name = GetHumanName();
            return newPlayer;
        }

        private static string GetHumanName()
        {
            return HumanNameGenerator.GenerateName();
        }
    }
}
