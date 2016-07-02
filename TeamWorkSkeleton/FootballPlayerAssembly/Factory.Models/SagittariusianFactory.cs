namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Global.Contracts;
    using Species.NameGenerator;

    public static partial class FootballPlayerFactory
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
        private static FootballPlayer CreateSagittariusianAttacker
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.SagittariusianFootballPlayer.FootballPlayerFactory
                .SagittariusianAttacker(baseStats);
            newPlayer.Name = GetSagittariusianName();
            return newPlayer;
        }

        private static FootballPlayer CreateSagittariusianDefender
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.SagittariusianFootballPlayer.FootballPlayerFactory
                .SagittariusianDefender(baseStats);
            newPlayer.Name = GetSagittariusianName();
            return newPlayer;
        }

        private static FootballPlayer CreateSagittariusianMidfielder
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.SagittariusianFootballPlayer.FootballPlayerFactory
                .SagittariusianMidfielder(baseStats);
            newPlayer.Name = GetSagittariusianName();
            return newPlayer;
        }

        private static FootballPlayer CreateSagittariusianGoalkeeper
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.SagittariusianFootballPlayer.FootballPlayerFactory
                .SagittariusianGoalkeeper(baseStats);
            newPlayer.Name = GetSagittariusianName();
            return newPlayer;
        }

        private static string GetSagittariusianName()
        {
            return SagittariusianNameGenerator.GenerateName();
        }
    }
}
