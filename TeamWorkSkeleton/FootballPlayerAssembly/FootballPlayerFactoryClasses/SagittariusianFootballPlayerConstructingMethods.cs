namespace FootballPlayerAssembly.FootballPlayerFactoryClasses
{
    using FootballPlayerAbstractClass;
    using SpeciesNameGenerators;

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
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetSagittariusianName();
            var newPlayer = new RolesClasses.SagittariusianFootballPlayer.FootballPlayerFactory
                .SagittariusianAttacker(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateSagittariusianDefender
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetSagittariusianName();
            var newPlayer = new RolesClasses.SagittariusianFootballPlayer.FootballPlayerFactory
                .SagittariusianDefender(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateSagittariusianMidfielder
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetSagittariusianName();
            var newPlayer = new RolesClasses.SagittariusianFootballPlayer.FootballPlayerFactory
                .SagittariusianMidfielder(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateSagittariusianGoalkeeper
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetSagittariusianName();
            var newPlayer = new RolesClasses.SagittariusianFootballPlayer.FootballPlayerFactory
                .SagittariusianGoalkeeper(baseStats);
            return newPlayer;
        }

        private static string GetSagittariusianName()
        {
            return SagittariusianNameGenerator.GenerateName();
        }
    }
}
