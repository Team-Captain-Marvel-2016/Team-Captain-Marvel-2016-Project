namespace TeamAssembly
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Global.Enumerations.Factory;
    using Global.Enumerations.Team;
    using RandomizersAssembly.StaticRandomizersClasses;
    using FootballPlayer = TeamWork.Models.Abstract.FootballPlayer;
    using FootballPlayerFactory = TeamWork.Models.Factory.Models.FootballPlayerFactory;

    public partial class FootballTeam
    {
        /// <summary>
        /// Randomly pick a formation out of the formations
        /// available through the FormationType enum.
        /// Then pass the picked formation to a method to generate a team.
        /// </summary>
        /// <returns> List of FootballPlayer objecs </returns>
        internal static List<FootballPlayer> CreateARandomFootballTeam(out FormationType returnFormation)
        {
            // Get the number of possible FormationType values.
            var formationSize = Enum
                .GetValues(typeof(FormationType))
                .Cast<FormationType>()
                .Count();

            // Generate a random number within that range.
            var typeIndex 
                = GenericRandomization.Random.Next(0, formationSize);

            // Get the formation associated with that int.
            var formation = (FormationType) typeIndex;

            // Generate a new team based on that formation.
            var output = CreateAFootballTeamByFormation(formation);

            returnFormation = formation;
            return output;
        }
        
        /// <summary>
        /// Generate players to fit in the formation provided as 
        /// input to this method. 
        /// Plus a GoalKeeper object.
        /// </summary>
        /// <param name="formation"></param>
        /// <returns> List of FootballPlayer objects </returns>
        internal static List<FootballPlayer> CreateAFootballTeamByFormation(FormationType formation)
        {
            var output = new List<FootballPlayer>();

            var numOfPlayersByPosition =
                ParseFormationType.GetFormationValues(formation);

            // Generate Goalkeeper
            output
                .Add(FootballPlayerFactory
                    .CreatePlayerByPosition(PositionType.Goalkeeper));

            // Generate numOfPlayersByPosition[0] Defenders.
            for (var i = 0; i < numOfPlayersByPosition[0]; i++)
            {
                output
                    .Add(FootballPlayerFactory
                        .CreatePlayerByPosition(PositionType.Defender));
            }

            // Generate numOfPlayersByPosition[1] Midfielders.
            for (var i = 0; i < numOfPlayersByPosition[1]; i++)
            {
                output
                    .Add(FootballPlayerFactory
                        .CreatePlayerByPosition(PositionType.Midfielder));
            }

            // Generate numOfPlayersByPosition[2] Attackers.
            for (var i = 0; i < numOfPlayersByPosition[2]; i++)
            {
                output
                    .Add(FootballPlayerFactory
                        .CreatePlayerByPosition(PositionType.Attacker));
            }

            return output;
        }
    }
}
