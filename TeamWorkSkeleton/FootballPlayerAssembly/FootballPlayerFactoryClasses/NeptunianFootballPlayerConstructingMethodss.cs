using FootballPlayerAssembly.FootballPlayerAbstractClass;
using FootballPlayerAssembly.SpeciesNameGenerators;

namespace FootballPlayerAssembly.FootballPlayerFactoryClasses
{
    public static partial class FootballPlayerFactory
    {
        internal static FootballPlayer CreateNeptunianAttacker(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory.NeptunianAttacker();
            return newPlayer;
        }

        internal static FootballPlayer CreateNeptunianDefender(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory.NeptunianDefender();
            return newPlayer;
        }

        internal static FootballPlayer CreateNeptunianMidfielder(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory.NeptunianMidfielder();
            return newPlayer;
        }

        internal static FootballPlayer CreateNeptunianGoalkeeper(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new RolesClasses.NeptunianFootballPlayer.FootballPlayerFactory.NeptunianGoalkeeper();
            return newPlayer;
        }
    }
}
