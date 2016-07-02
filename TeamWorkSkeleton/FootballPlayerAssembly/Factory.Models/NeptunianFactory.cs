namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Global.Contracts;
    using Species.NameGenerator;

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
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianAttacker(baseStats);
            newPlayer.Name = GetNeptunianName();
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianDefender
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianDefender(baseStats);
            newPlayer.Name = GetNeptunianName();
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianMidfielder
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianMidfielder(baseStats);
            newPlayer.Name = GetNeptunianName();
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianGoalkeeper
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianGoalkeeper(baseStats);
            newPlayer.Name = GetNeptunianName();
            return newPlayer;
        }

        private static string GetNeptunianName()
        {
            return NeptunianNameGenerator.GenerateName();
        }
    }
}
