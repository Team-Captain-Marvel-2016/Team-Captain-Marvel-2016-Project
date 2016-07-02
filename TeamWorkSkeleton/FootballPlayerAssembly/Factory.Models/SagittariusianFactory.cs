namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Global.Contracts;
    using Species.NameGenerator;

    public partial class FootballPlayerFactory
    {
        /// <summary>
        /// Creates a new Sagittariusian player object 
        /// applying previously generated set of base 
        /// FootballPlayer base abstract stats
        /// wrapped in a GenericFootballPlayer object
        /// </summary>
        /// <param name="baseStats"> 
        /// set of stats wrapped in a GenericFootballPlayer object 
        /// </param>
        /// <returns>new Sagittariusian(Position) object</returns>
        private FootballPlayer CreateSagittariusianAttacker
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.SagittariusianFootballPlayer.FootballPlayerFactory
                .SagittariusianAttacker(baseStats);
            newPlayer.Name = GetSagittariusianName();
            return newPlayer;
        }

        private FootballPlayer CreateSagittariusianDefender
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.SagittariusianFootballPlayer.FootballPlayerFactory
                .SagittariusianDefender(baseStats);
            newPlayer.Name = GetSagittariusianName();
            return newPlayer;
        }

        private FootballPlayer CreateSagittariusianMidfielder
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.SagittariusianFootballPlayer.FootballPlayerFactory
                .SagittariusianMidfielder(baseStats);
            newPlayer.Name = GetSagittariusianName();
            return newPlayer;
        }

        private FootballPlayer CreateSagittariusianGoalkeeper
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.SagittariusianFootballPlayer.FootballPlayerFactory
                .SagittariusianGoalkeeper(baseStats);
            newPlayer.Name = GetSagittariusianName();
            return newPlayer;
        }

        private string GetSagittariusianName()
        {
            return SagittariusianNameGenerator.GenerateName();
        }
    }
}
