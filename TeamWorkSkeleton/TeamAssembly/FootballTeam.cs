namespace TeamAssembly
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Global.Contracts;
    using Global.Enumerations.Team;
    using FootballPlayer = TeamWork.Models.Abstract.FootballPlayer;

    public partial class FootballTeam : IEnumerable<FootballPlayer>
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

            this.Formation = formation;
        }

        public FootballTeam(string teamName, FormationType formation)
            : this(teamName)

        {
            this.Formation = formation;

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
            set
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

        public FormationType Formation { get; private set; }

        public bool HasBall { get; set; }


        public void CreateTeam(FormationType formation)
        {
            this.Formation = formation;

            this.Team =
                CreateAFootballTeamByFormation(formation);
        }

        public void CreateTeam()
        {
            FormationType formation;

            this.Team =
                CreateARandomFootballTeam(out formation);

            this.Formation = formation;
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
