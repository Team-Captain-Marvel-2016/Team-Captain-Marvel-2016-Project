namespace TeamAssembly
{
    using Global.Contracts;
    using Global.Enumerations.Team;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using TeamWork.Models.Factory.Models;

    /// <summary>
    /// Team of IFootballPlayer
    /// </summary>
    public partial class FootballTeam : ITeam, IEnumerable<IFootballPlayer>
    {
        private string teamName;

        private IFactory factory;

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

        public IList<IFootballPlayer> Team { get; set; }

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

        /// <summary>
        /// Generates a team out of a preset formation.
        /// </summary>
        /// <param name="formation"></param>
        public void CreateTeam(FormationType formation)
        {
            this.CreateFactory();

            this.FormationType = formation;

            this.Team =
                CreateAFootballTeamByFormation(formation);

            this.ClearFactory();
        }

        /// <summary>
        /// Picks a formation from the enum FormationType
        /// and creates a team based on that formation.
        /// </summary>
        public void CreateTeam()
        {
            this.CreateFactory();

            FormationType formation;

            this.Team =
                CreateARandomFootballTeam(out formation);

            this.FormationType = formation;

            this.ClearFactory();
        }

        public IEnumerator<IFootballPlayer> GetEnumerator()
        {
            foreach (var footballPlayer in this.Team)
            {
                yield return footballPlayer;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void CreateFactory()
        {
            this.factory = new FootballPlayerFactory();
        }

        private void ClearFactory()
        {
            this.factory = null;
        }
    }
}
