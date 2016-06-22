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
        private static FootballPlayer CreateMartianAttacker
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMartianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.MartianFootballPlayer.FootballPlayerFactory
                .MartianAttacker(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateMartianDefender
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMartianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.MartianFootballPlayer.FootballPlayerFactory
                .MartianDefender(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateMartianMidfielder
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMartianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.MartianFootballPlayer.FootballPlayerFactory
                .MartianMidfielder(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateMartianGoalkeeper
            (TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMartianName();
            var newPlayer = new FootballPlayerAssembly.RolesClasses.MartianFootballPlayer.FootballPlayerFactory
                .MartianGoalkeeper(baseStats);
            return newPlayer;
        }

        private static string GetMartianName()
        {
            return MartianNameGenerator.GenerateName();
        }
    }
}
