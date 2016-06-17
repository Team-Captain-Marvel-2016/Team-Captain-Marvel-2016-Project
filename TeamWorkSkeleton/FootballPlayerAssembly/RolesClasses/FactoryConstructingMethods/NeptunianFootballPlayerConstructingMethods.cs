namespace FootballPlayerAssembly.RolesClasses.FactoryConstructingMethods
{
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using FootballPlayerAssembly.SpeciesNameGenerators;

    public static partial class FootballPlayerFactory
    {
        private static FootballPlayer CreateNeptunianAtacker(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new NeptunianFootballPlayer.FootballPlayerFactory.NeptunianAttacker();
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianDefender(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new NeptunianFootballPlayer.FootballPlayerFactory.NeptunianDefender();
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianMidfielder(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new NeptunianFootballPlayer.FootballPlayerFactory.NeptunianMidfielder();
            return newPlayer;
        }

        private static FootballPlayer CreateNeptunianGoalkeeper(FootballPlayer baseStats)
        {
            var newPlayerName = NeptuneNameGenerator.GenerateName();
            var newPlayer = new NeptunianFootballPlayer.FootballPlayerFactory.NeptunianGoalkeeper();
            return newPlayer;
        }
    }
}
