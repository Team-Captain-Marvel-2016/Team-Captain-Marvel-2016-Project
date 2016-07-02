namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Global.Contracts;
    using Species.NameGenerator;

    public partial class FootballPlayerFactory
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
        private FootballPlayer CreateNeptunianAttacker
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianAttacker(baseStats);
            newPlayer.Name = GetNeptunianName();
            return newPlayer;
        }

        private FootballPlayer CreateNeptunianDefender
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianDefender(baseStats);
            newPlayer.Name = GetNeptunianName();
            return newPlayer;
        }

        private FootballPlayer CreateNeptunianMidfielder
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianMidfielder(baseStats);
            newPlayer.Name = GetNeptunianName();
            return newPlayer;
        }

        private FootballPlayer CreateNeptunianGoalkeeper
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianGoalkeeper(baseStats);
            newPlayer.Name = GetNeptunianName();
            return newPlayer;
        }

        private string GetNeptunianName()
        {
            return NeptunianNameGenerator.GenerateName();
        }
    }
}
