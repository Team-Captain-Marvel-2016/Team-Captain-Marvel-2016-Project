using TeamAssembly;
using TeamAssembly.FormationTypeParsingMethods;

namespace VisualizationAssembly.InitPlayingFieldClasses
{
    using Enumerations;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class InitTeamVisualization
    {
        internal static void GetInitialFootballPlayerPositions(this FootballTeam team, StartingFieldType field)
        {
            var formationValues =
                ParseFormationType
                    .GetFormationValues(team.Formation);
        }
    }
}
