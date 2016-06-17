namespace TestingAssembly.FootballPlayerFactoryTesting
{
    using FootballPlayerAssembly.FootballPlayerFactoryClasses;

    public static class FootballPlayerFactoryInitialTesting
    {
        public static void Test_01()
        {
            FootballPlayerFactory.CreatePlayer(false);
        }
    }
}
