namespace _00_TestingClassesAssembly.CreateFootballTeamTesting
{
    using System;
    using TeamAssembly;
    using VisualizationAssembly.Enumerations;
    using VisualizationAssembly.InitPlayingFieldClasses;

    public static class CreatingNewFootballTeamTests
    {
        public static void Test_01()
        {
            var testTeam = new FootballTeam("Testing", true);
            Console.WriteLine(string.Join(Environment.NewLine, testTeam.Team));

            InitTeamVisualization.GetInitialFootballPlayerPositions(testTeam, StartingFieldType.Left);
        }
    }
}
