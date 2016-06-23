namespace TeamAssembly
{
    using Global.Contracts;
    using Global.Enumerations.Team;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using TeamWork.Models.Abstract;

    public partial class FootballTeam : ITeam, IEnumerable<FootballPlayer>
    {
        private string teamName;

        public FootballTeam(string teamName)
        {
            this.TeamName = teamName;
            this.Team = new List<IFootballPlayer>();
        }

        public FootballTeam(string teamName, bool generateRandomTeam)
            : this(teamName)
        {
            if (!generateRandomTeam) return;

            FormationType formation;

            this.Team =
                CreateARandomFootballTeam(out formation);

            this.FormationType = formation;
        }

        public FootballTeam(string teamName, FormationType formation)
            : this(teamName)

        {
            this.FormationType = formation;

            this.Team =
                CreateAFootballTeamByFormation(formation);
        }

        public List<IFootballPlayer> Team { get; set; }

        public string TeamName
        {
            get
            {
                return this.teamName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Team Name is null or empty");
                }
                else
                {
                    this.teamName = value;
                }
            }
        }

        public FormationType FormationType { get; private set; }

        public bool HasBallPossession { get; set; }

        public void SetTeamName(string teamName)
        {
            this.teamName = teamName;
        }

        public void CreateTeam(FormationType formation)
        {
            this.FormationType = formation;

            this.Team =
                CreateAFootballTeamByFormation(formation);
        }

        public void CreateTeam()
        {
            FormationType formation;

            this.Team =
                CreateARandomFootballTeam(out formation);

            this.FormationType = formation;
        }

        public IEnumerator<FootballPlayer> GetEnumerator()
        {
            return ((IEnumerable<FootballPlayer>)this.Team).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
