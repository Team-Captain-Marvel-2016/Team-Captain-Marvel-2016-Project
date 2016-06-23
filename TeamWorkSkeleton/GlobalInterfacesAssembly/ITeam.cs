namespace Global.Contracts
{
    using Enumerations.Team;
    using System.Collections.Generic;

    public interface ITeam
    {
        string TeamName { get; }

        bool HasBallPossession { get; set; }

        List<IFootballPlayer> Team { get; }

        FormationType FormationType { get; }
        
        void SetTeamName(string teamName);

        void CreateTeam(FormationType formationType);

        void CreateTeam();
    }
}