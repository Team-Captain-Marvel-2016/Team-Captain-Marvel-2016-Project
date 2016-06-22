namespace _00_TestingClassesAssembly.FootballPlayerFactoryTesting
{
    using FootballPlayerFactory = TeamWork.Models.Factory.Models.FootballPlayerFactory;

    public static class FootballPlayerFactoryInitialTesting
    {
        public static void Test_01()
        {
            var test = FootballPlayerFactory.CreatePlayer();
        }
    }
}
