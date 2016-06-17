namespace FootballPlayerAssembly.FootballPlayerFactoryClasses.GenericFootballPlayerClasses
{
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class CreateGenericFootballPlayer
    {
        internal static FootballPlayer CreateGenericAttacker()
        {
            // TODO: 
            return new FootballPlayerFactory.GenericFootballPlayer(string.Empty);
        }

        internal static FootballPlayer CreateGenericDefender()
        {
            // TODO: 
            return new FootballPlayerFactory.GenericFootballPlayer(string.Empty);
        }

        internal static FootballPlayer CreateGenericMidfielder()
        {
            // TODO: 
            return new FootballPlayerFactory.GenericFootballPlayer(string.Empty);
        }

        internal static FootballPlayer CreateGenericGoalkeeper()
        {
            // TODO: 
            return new FootballPlayerFactory.GenericFootballPlayer(string.Empty);
        }
    }
}
