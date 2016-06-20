namespace FootballPlayerAssembly.FootballPlayerFactoryClasses
{
    using FootballPlayerAbstractClass;
    using SpeciesNameGenerators;
    using System;

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
        private static FootballPlayer CreateVenusianAttacker
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .VenusianAttacker(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateVenusianDefender
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .VenusianDefender(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateVenusianMidfielder
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .VenusianMidfielder(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateVenusianGoalkeeper
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .VenusianGoalkeeper(baseStats);
            return newPlayer;
        }
    }
}
