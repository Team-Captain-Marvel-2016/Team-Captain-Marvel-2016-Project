namespace FootballPlayerAssembly.FootballPlayerFactoryClasses
{
    using FootballPlayerAbstractClass;
    using SpeciesNameGenerators;
    using System;

    public static partial class FootballPlayerFactory
    {
        private static FootballPlayer CreateNeptunianAttacker(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianAttacker(string.Empty);
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianDefender(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianDefender(string.Empty);
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianMidfielder(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianMidfielder(string.Empty);
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianGoalkeeper(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory
                .NeptunianGoalkeeper(string.Empty);
            return newPlayer;
        }
    }
}
