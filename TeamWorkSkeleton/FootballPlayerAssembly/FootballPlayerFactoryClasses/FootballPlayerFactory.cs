namespace FootballPlayerAssembly.FootballPlayerFactoryClasses
{
    using Enumerations;
    using FootballPlayerAbstractClass;
    using GenericFootballPlayerClasses;
    using System;
    using System.Linq;
    using System.Reflection;

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
            return new GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer(string.Empty);
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
            // Generate base stats.
            var baseStatsGeneric = CreateGenericFootballPlayer.CreateGenericAttacker();

            // Pick Species.
            var species = PickSpecies();
            
            // Call the corresponing constructor intermediate method.
            var methodName = $"Create{species}Attacker";
            var creatingMethod = typeof(FootballPlayerFactory).GetMethod(methodName,
                BindingFlags.NonPublic | BindingFlags.Static);

            var newAttacker = (FootballPlayer)creatingMethod
                .Invoke(null, new object[] { baseStatsGeneric });

            return newAttacker;
        }

        private static FootballPlayer CreateDefender()
        {
            // Generate base stats.
            var baseStatsGeneric = CreateGenericFootballPlayer.CreateGenericDefender();

            // Pick Species.
            var species = PickSpecies();

            // Call the corresponing constructor intermediate method.
            var methodName = $"Create{species}Defender";
            var creatingMethod = typeof(FootballPlayerFactory).GetMethod(methodName,
                BindingFlags.NonPublic | BindingFlags.Static);

            var newDefender = (FootballPlayer)creatingMethod
                .Invoke(null, new object[] { baseStatsGeneric });

            return newDefender;
        }

        private static FootballPlayer CreateMidfielder()
        {
            // Generate base stats.
            var baseStatsGeneric = CreateGenericFootballPlayer.CreateGenericMidfielder();

            // Pick Species.
            var species = PickSpecies();

            // Call the corresponing constructor intermediate method.
            var methodName = $"Create{species}Midfielder";
            var creatingMethod = typeof(FootballPlayerFactory).GetMethod(methodName,
                BindingFlags.NonPublic | BindingFlags.Static);

            var newMidfielder = (FootballPlayer)creatingMethod
                .Invoke(null, new object[] { baseStatsGeneric });

            return newMidfielder;
        }

        private static FootballPlayer CreateGoalkeeper()
        {
            // Generate base stats.
            var baseStatsGeneric = CreateGenericFootballPlayer.CreateGenericGoalkeeper();

            // Pick Species.
            var species = PickSpecies();

            // Call the corresponing constructor intermediate method.
            var methodName = $"Create{species}Goalkeeper";
            var creatingMethod = typeof(FootballPlayerFactory).GetMethod(methodName,
                BindingFlags.NonPublic | BindingFlags.Static);

            var newGoalkeeper = (FootballPlayer)creatingMethod
                .Invoke(null, new object[] { baseStatsGeneric });

            return newGoalkeeper;
        }

        private static string PickSpecies()
        {
            // Get size of enum 
            var enumSize = Enum.GetValues(typeof(SpeciesType))
                .Cast<SpeciesType>().Count();

            var speciesIndex = Random.Next(0, enumSize);
            var speciesName = (SpeciesType)speciesIndex;

            return speciesName.ToString();
        }
        #endregion
    }
}
