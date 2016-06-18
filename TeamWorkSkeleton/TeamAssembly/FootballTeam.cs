namespace TeamAssembly
{
    using CreateTeamMethods;
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using FormationTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FootballTeam
    {
        private string _teamName;
        private List<FootballPlayer> _team;

        #region Constructors
        public FootballTeam(string teamName)
        {
            this.TeamName = teamName;
            _team = new List<FootballPlayer>();
        }

        public FootballTeam(string teamName, bool generateRandomTeam)
            : this(teamName)
        {
            if (generateRandomTeam)
            {
                this.Team = CreateFootballTeam
                    .CreateARandomFootballTeam();
            }
        }

        public FootballTeam(string teamName, FormationType formation)
            : this(teamName)

        {
            this.Team = CreateFootballTeam
                .CreateAFootballTeamByFormation(formation);
        }
        #endregion

        #region Properties
        public List<FootballPlayer> Team
        {
            get
            {
                // Create a copy of the current 
                // _team and pass it back;
                var output = new FootballPlayer[this._team.Count];

                _team.CopyTo(output);

                return output.ToList();
            }
            private set
            {
                _team = value;
            }
        }

        public string TeamName
        {
            get
            {
                return _teamName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Team Name is null or empty");
                }
                else
                {
                    _teamName = value;
                }
            }
        }

        #endregion

        public void CreateTeam(FormationType formation)
        {
            this.Team = CreateFootballTeam
                .CreateAFootballTeamByFormation(formation);
        }

    }
}
