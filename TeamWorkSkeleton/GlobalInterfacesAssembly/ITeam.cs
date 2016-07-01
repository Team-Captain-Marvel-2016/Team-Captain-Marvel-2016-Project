namespace Global.Contracts
{
    using Global.Enumerations.Team;
    using System.Collections.Generic;

    public interface ITeam : IEnumerable<IFootballPlayer>
    {
        string TeamName { get; }

        bool HasBallPossession { get; set; }

        List<IFootballPlayer> Team { get; }

        FormationType FormationType { get; }
        
        void SetTeamName(string teamName);

        void CreateTeam(FormationType formationType);

        void CreateTeam();

        void GetInitialFootballPlayerPositions
            (int rows, int cols, StartingFieldType field);
    }
}