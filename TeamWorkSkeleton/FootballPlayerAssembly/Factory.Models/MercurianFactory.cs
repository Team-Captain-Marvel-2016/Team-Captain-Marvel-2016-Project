namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Global.Contracts;
    using Species.NameGenerator;

    public partial class FootballPlayerFactory
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
        private FootballPlayer CreateMercurianAttacker
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.MercurianFootballPlayer.FootballPlayerFactory
                .MercurianAttacker(baseStats);
            newPlayer.Name = GetMercurianName();
            return newPlayer;
        }

        private FootballPlayer CreateMercurianDefender
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.MercurianFootballPlayer.FootballPlayerFactory
                .MercurianDefender(baseStats);
            newPlayer.Name = GetMercurianName();
            return newPlayer;
        }

        private FootballPlayer CreateMercurianMidfielder
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.MercurianFootballPlayer.FootballPlayerFactory
                .MercurianMidfielder(baseStats);
            newPlayer.Name = GetMercurianName();
            return newPlayer;
        }

        private FootballPlayer CreateMercurianGoalkeeper
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.MercurianFootballPlayer.FootballPlayerFactory
                .MercurianGoalkeeper(baseStats);
            newPlayer.Name = GetMercurianName();
            return newPlayer;
        }

        private string GetMercurianName()
        {
            return MercurianNameGenerator.GenerateName();
        }
    }
}
