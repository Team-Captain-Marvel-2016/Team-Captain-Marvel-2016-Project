﻿namespace FootballPlayerAssembly.FootballPlayerFactoryClasses
{
    using FootballPlayerAbstractClass;
    using SpeciesNameGenerators;

    public static partial class FootballPlayerFactory
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
        /// <returns>new Martian(Position) object</returns>
        private static FootballPlayer CreateMercurianAttacker
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMercurianName();
            var newPlayer = new RolesClasses.MercurianFootballPlayer.FootballPlayerFactory
                .MercurianAttacker(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateMercurianDefender
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMercurianName();
            var newPlayer = new RolesClasses.MartianFootballPlayer.FootballPlayerFactory
                .MercurianDefender(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateMercurianMidfielder
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMercurianName();
            var newPlayer = new RolesClasses.MartianFootballPlayer.FootballPlayerFactory
                .MercurianMidfielder(baseStats);
            return newPlayer;
        }

        private static FootballPlayer CreateMercurianGoalkeeper
            (GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer baseStats)
        {
            var newPlayerName = GetMercurianName();
            var newPlayer = new RolesClasses.MartianFootballPlayer.FootballPlayerFactory
                .MercurianGoalkeeper(baseStats);
            return newPlayer;
        }

        private static string GetMercurianName()
        {
            return MercurianNameGenerator.GenerateName();
        }
    }
}
