namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Global.Contracts;
    using Species.NameGenerator;

    public partial class FootballPlayerFactory
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
        private FootballPlayer CreateUranianAttacker
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.UranianFootballPlayer.FootballPlayerFactory
                .UranianAttacker(baseStats);
            newPlayer.Name = GetUranianName();
            return newPlayer;
        }

        private FootballPlayer CreateUranianDefender
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.UranianFootballPlayer.FootballPlayerFactory
                .UranianDefender(baseStats);
            newPlayer.Name = GetUranianName();
            return newPlayer;
        }

        private FootballPlayer CreateUranianMidfielder
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.UranianFootballPlayer.FootballPlayerFactory
                .UranianMidfielder(baseStats);
            newPlayer.Name = GetUranianName();
            return newPlayer;
        }

        private FootballPlayer CreateUranianGoalkeeper
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.UranianFootballPlayer.FootballPlayerFactory
                .UranianGoalkeeper(baseStats);
            newPlayer.Name = GetUranianName();
            return newPlayer;
        }

        private string GetUranianName()
        {
            return UranianNameGenerator.GenerateName();
        }
    }
}
