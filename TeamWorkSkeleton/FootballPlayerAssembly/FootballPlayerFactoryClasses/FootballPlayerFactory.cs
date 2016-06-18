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
        /// <summary>
        /// Randomly pick a Position.
        /// Call the corresponding method.
        /// </summary>
        /// <returns>new FootballPlayer object</returns>
        public static FootballPlayer CreatePlayer()
        {
            // Randomly generate a position and pass it along.
            var enumSize = Enum.GetValues(typeof(PositionType))
                .Cast<PositionType>()
                .Count();

            var positionEnumIndex = Random.Next(0, enumSize);

            var positionName = (PositionType)positionEnumIndex;

            var newlyGeneratedPlayer = CreatePlayerByPosition(positionName);

            return newlyGeneratedPlayer;
        }
        
        /// <summary>
        /// Create a new FootballPlayer by a givern position
        /// </summary>
        /// <param name="position"></param>
        /// <returns>FootballPlayer object</returns>
        public static FootballPlayer CreatePlayerByPosition(PositionType position)
        {
            const string methodNameFormat = "Create{0}";

            var methodName = string.Format(methodNameFormat, position);

            var method = typeof(FootballPlayerFactory)
                .GetMethod(methodName,
                    BindingFlags.NonPublic | BindingFlags.Static);

            var newlyGeneratedPlayer =
                (FootballPlayer)method
                    .Invoke(null, new object[] { });

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
            var baseStatsGenericPlayer =
                CreateGenericFootballPlayer.CreateGenericAttacker(Random);

            // Pick Species.
            var species = PickSpecies();

            // Call the corresponing constructor intermediate method.
            var methodName = $"Create{species}Attacker";
            var creatingMethod = typeof(FootballPlayerFactory).GetMethod(methodName,
                BindingFlags.NonPublic | BindingFlags.Static);

            var newAttacker = (FootballPlayer)creatingMethod
                .Invoke(null, new object[] { baseStatsGenericPlayer });

            return newAttacker;
        }

        private static FootballPlayer CreateDefender()
        {
            // Generate base stats.
            var baseStatsGeneric =
                CreateGenericFootballPlayer.CreateGenericDefender(Random);

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
            var baseStatsGeneric =
                CreateGenericFootballPlayer.CreateGenericMidfielder(Random);

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
            var baseStatsGeneric =
                CreateGenericFootballPlayer.CreateGenericGoalkeeper(Random);

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
