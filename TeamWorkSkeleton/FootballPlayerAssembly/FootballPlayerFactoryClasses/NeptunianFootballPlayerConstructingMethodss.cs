using FootballPlayerAssembly.FootballPlayerAbstractClass;
using FootballPlayerAssembly.SpeciesNameGenerators;

namespace FootballPlayerAssembly.FootballPlayerFactoryClasses
{
    public static partial class FootballPlayerFactory
    {
        private static FootballPlayer CreateNeptunianAttacker(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory.NeptunianAttacker();
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianDefender(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory.NeptunianDefender();
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianMidfielder(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory.NeptunianMidfielder();
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianGoalkeeper(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory.NeptunianGoalkeeper();
            return newPlayer;
        }
    }
}
