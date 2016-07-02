namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Global.Contracts;
    using Species.NameGenerator;

    public partial class FootballPlayerFactory
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
        private FootballPlayer CreateHumanAttacker
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.HumanFootballPlayer.FootballPlayerFactory
                .HumanAttacker(baseStats);
            newPlayer.Name = GetHumanName();
            return newPlayer;
        }

        private FootballPlayer CreateHumanDefender
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.HumanFootballPlayer.FootballPlayerFactory
                .HumanDefender(baseStats);
            newPlayer.Name = GetHumanName();
            return newPlayer;
        }

        private FootballPlayer CreateHumanMidfielder
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.HumanFootballPlayer.FootballPlayerFactory
                .HumanMidfielder(baseStats);
            newPlayer.Name = GetHumanName();
            return newPlayer;
        }

        private FootballPlayer CreateHumanGoalkeeper
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.HumanFootballPlayer.FootballPlayerFactory
                .HumanGoalkeeper(baseStats);
            newPlayer.Name = GetHumanName();
            return newPlayer;
        }

        private string GetHumanName()
        {
            return HumanNameGenerator.GenerateName();
        }
    }
}
