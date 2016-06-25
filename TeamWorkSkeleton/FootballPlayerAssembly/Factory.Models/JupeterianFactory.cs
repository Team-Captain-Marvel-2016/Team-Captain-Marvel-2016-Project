namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Species.NameGenerator;

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
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayer = new Roles.JupiterianFootballPlayer.FootballPlayerFactory
                .JupiterianAttacker(baseStats);
            newPlayer.Name = GetJupiterianName();
            return newPlayer;
        }

        private static FootballPlayer CreateJupiterianDefender
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayer = new Roles.JupiterianFootballPlayer.FootballPlayerFactory
                .JupiterianDefender(baseStats);
            newPlayer.Name = GetJupiterianName();
            return newPlayer;
        }

        private static FootballPlayer CreateJupiterianMidfielder
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayer = new Roles.JupiterianFootballPlayer.FootballPlayerFactory
                .JupiterianMidfielder(baseStats);
            newPlayer.Name = GetJupiterianName();
            return newPlayer;
        }

        private static FootballPlayer CreateJupiterianGoalkeeper
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayer = new Roles.JupiterianFootballPlayer.FootballPlayerFactory
                .JupiterianGoalkeeper(baseStats);
            newPlayer.Name = GetJupiterianName();
            return newPlayer;
        }

        private static string GetJupiterianName()
        {
            return JupiterianNameGenerator.GenerateName();
        }
    }
}
