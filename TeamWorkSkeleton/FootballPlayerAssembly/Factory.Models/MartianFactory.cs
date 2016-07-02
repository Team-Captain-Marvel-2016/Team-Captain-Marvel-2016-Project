namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Global.Contracts;
    using Species.NameGenerator;

    public partial class FootballPlayerFactory
    {
        /// <summary>
        /// Creates a new Martian player object 
        /// applying previously generated set of base 
        /// FootballPlayer base abstract stats
        /// wrapped in a GenericFootballPlayer object
        /// </summary>
        /// <param name="baseStats"> 
        /// set of stats wrapped in a GenericFootballPlayer object 
        /// </param>
        /// <returns>new Martian(Position) object</returns>
        private FootballPlayer CreateMartianAttacker
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.MartianFootballPlayer.FootballPlayerFactory
                .MartianAttacker(baseStats);
            newPlayer.Name = GetMartianName();
            return newPlayer;
        }

        private FootballPlayer CreateMartianDefender
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.MartianFootballPlayer.FootballPlayerFactory
                .MartianDefender(baseStats);
            newPlayer.Name = GetMartianName();
            return newPlayer;
        }

        private FootballPlayer CreateMartianMidfielder
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.MartianFootballPlayer.FootballPlayerFactory
                .MartianMidfielder(baseStats);
            newPlayer.Name = GetMartianName();
            return newPlayer;
        }

        private FootballPlayer CreateMartianGoalkeeper
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.MartianFootballPlayer.FootballPlayerFactory
                .MartianGoalkeeper(baseStats);
            newPlayer.Name = GetMartianName();
            return newPlayer;
        }

        private string GetMartianName()
        {
            return MartianNameGenerator.GenerateName();
        }
    }
}
