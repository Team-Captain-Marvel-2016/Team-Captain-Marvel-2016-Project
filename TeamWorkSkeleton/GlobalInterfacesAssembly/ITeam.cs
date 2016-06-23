namespace Global.Contracts
{
    using Enumerations.Team;
    using System.Collections.Generic;

    public interface ITeam
    {
        List<IFootballPlayer> Team { get; }
        string TeamName { get; }
        void SetTeamName(string teamName);
        void CreateTeam(FormationType formationType);
        void CreateTeam();
        bool HasBallPossession { get; set; }
        FormationType FormationType { get; }
    }
}