namespace TeamAssembly
{
    using CreateTeamMethods;
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using FormationTypes;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class FootballTeam : IEnumerable<FootballPlayer>
    {
        private string _teamName;

        #region Constructors
        public FootballTeam(string teamName)
        {
            this.TeamName = teamName;
            Team = new List<FootballPlayer>();
        }

        public FootballTeam(string teamName, bool generateRandomTeam)
            : this(teamName)
        {
            if (!generateRandomTeam) return;

            FormationType formation;

            this.Team = CreateFootballTeam
                .CreateARandomFootballTeam(out formation);

            this.Formation = formation;
        }

        public FootballTeam(string teamName, FormationType formation)
            : this(teamName)

        {
            this.Formation = formation;

            this.Team = CreateFootballTeam
                .CreateAFootballTeamByFormation(formation);
        }
        #endregion

        #region Properties
        public List<FootballPlayer> Team { get; set; }

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

        public FormationType Formation { get; private set; }

        #endregion

        public void CreateTeam(FormationType formation)
        {
            this.Formation = formation;

            this.Team = CreateFootballTeam
                .CreateAFootballTeamByFormation(formation);
        }

        public void CreateTeam()
        {
            FormationType formation;

            this.Team = CreateFootballTeam
                .CreateARandomFootballTeam(out formation);

            this.Formation = formation;
        }

        #region Interface Implementation
        public IEnumerator<FootballPlayer> GetEnumerator()
        {
            return ((IEnumerable<FootballPlayer>) this.Team).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();
        }
        #endregion
    }
}
