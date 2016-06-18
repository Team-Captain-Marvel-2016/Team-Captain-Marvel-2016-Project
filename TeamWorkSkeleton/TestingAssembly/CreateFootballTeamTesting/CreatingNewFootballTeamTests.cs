using VisualizationAssembly.Enumerations;
using VisualizationAssembly.InitPlayingFieldClasses;

namespace TestingAssembly.CreateFootballTeamTesting
{
    using System;
    using TeamAssembly;

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
