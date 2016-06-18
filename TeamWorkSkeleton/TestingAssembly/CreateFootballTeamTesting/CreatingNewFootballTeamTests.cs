
namespace TestingAssembly.CreateFootballTeamTesting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamAssembly;

    public static class CreatingNewFootballTeamTests
    {
        public static void Test_01()
        {
            var testTeam = new FootballTeam(true);
        }
    }
}
