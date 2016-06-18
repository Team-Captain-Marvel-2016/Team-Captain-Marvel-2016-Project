using System.Collections.Generic;
using FootballPlayerAssembly.FootballPlayerAbstractClass;

namespace TeamAssembly.CreateTeamMethods
{
    using System;
    using FormationTypes;
    using FormationTypeParsingMethods;

    internal static class CreateFootballTeam
    {
        #region Static Fields
        private static Random _random;

        static CreateFootballTeam()
        {
            _random = new Random();
        }
        #endregion

        internal static List<FootballPlayer> CreateARandomFootballTeam()
        {
            // Get random formation
            
            return new List<FootballPlayer>();
        }

        internal static List<FootballPlayer> CreateAFootballTeamByFormation(FormationType formation)
        {
            var output = new List<FootballPlayer>();

            var numOfPlayersByPosition =
                ParseFormationType.GetFormationValues(formation);


            return output;
        }
    }
}
