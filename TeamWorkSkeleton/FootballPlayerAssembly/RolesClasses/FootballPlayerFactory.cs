namespace FootballPlayerAssembly.RolesClasses
{
    using FootballPlayerAbstractClass;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Methods for generating a random player
    /// </summary>
    public static partial class FootballPlayerFactory
    {
        #region Static fields and consructor
        private static Random _random;

        static FootballPlayerFactory()
        {
            _random = new Random();
        }
        #endregion


        public static FootballPlayer CreatePlayer(bool isAttacket, bool isMidfielder, bool isDefender, bool isGoalkeeper)
        {



            return new HumanFootballPlayer.FootballPlayerFactory.HumanAttacker();
        }

        public static object CreatePlayer()
        {
            
            return new object();
        }
    }
}
