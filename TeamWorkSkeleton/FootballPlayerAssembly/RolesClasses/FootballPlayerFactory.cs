using System.Reflection;

namespace FootballPlayerAssembly.RolesClasses
{
    using Enumerations;
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
        private static readonly Random Random;

        static FootballPlayerFactory()
        {
            Random = new Random();
        }
        #endregion

        #region Public methods
        public static FootballPlayer CreatePlayer(bool isAttacker, bool isMidfielder, bool isDefender, bool isGoalkeeper)
        {
            return new NeptunianFootballPlayer.FootballPlayerFactory.NeptunianAttacker();
        }

        /// <summary>
        /// Randomly pick a Position.
        /// Call the corresponding method.
        /// </summary>
        /// <param name="includeGoalkeeper"></param>
        /// <returns>new FootballPlayer object</returns>
        public static FootballPlayer CreatePlayer(bool includeGoalkeeper)
        {
            const string methodNameFormat = "Create{0}";
            
            var enumSize = Enum.GetValues(typeof(PositionType))
                .Cast<PositionType>()
                .Count();

            var positionEnumIndex = Random.Next(0, enumSize);

            var positionName = (PositionType)positionEnumIndex;
            var methodName = string.Format(methodNameFormat, positionName);

            var method = typeof(FootballPlayerFactory).GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Static);

            var newlyGeneratedPlayer = (FootballPlayer)method.Invoke(null, new object[] { });
            
            return newlyGeneratedPlayer;
        }
        #endregion

        #region Generete Player Stats by given position
        /// <summary>
        /// Generate appropriate stats for the currently selected position
        /// and pick a species.
        /// Pass the date to the corresponding contucting method.
        /// </summary>
        /// <returns></returns>
        private static FootballPlayer CreateAttacker()
        {

            return new NeptunianFootballPlayer.FootballPlayerFactory.NeptunianAttacker();
        }

        private static FootballPlayer CreateDefender()
        {

            return new NeptunianFootballPlayer.FootballPlayerFactory.NeptunianDefender();
        }

        private static FootballPlayer CreateMidfielder()
        {

            return new NeptunianFootballPlayer.FootballPlayerFactory.NeptunianMidfielder();
        }

        private static FootballPlayer CreateGoalkeeper()
        {

            return new NeptunianFootballPlayer.FootballPlayerFactory.NeptunianGoalkeeper();
        }
        #endregion
    }
}
