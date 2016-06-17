
using FootballPlayerAssembly.RolesClasses;

namespace TestingAssembly.FootballPlayerFactoryTesting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class FootballPlayerFactoryInitialTesting
    {
        public static void Test_01()
        {
            FootballPlayerFactory.CreatePlayer(false);
        }
    }
}
