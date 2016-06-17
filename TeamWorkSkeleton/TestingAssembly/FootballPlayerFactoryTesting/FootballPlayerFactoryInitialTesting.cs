namespace TestingAssembly.FootballPlayerFactoryTesting
{
    using FootballPlayerAssembly.FootballPlayerFactoryClasses;

    public static class FootballPlayerFactoryInitialTesting
    {
        public static void Test_01()
        {
            var test = FootballPlayerFactory.CreatePlayer(false);
        }
    }
}
