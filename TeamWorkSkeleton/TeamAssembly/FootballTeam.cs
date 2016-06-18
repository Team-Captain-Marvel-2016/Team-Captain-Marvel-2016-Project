namespace TeamAssembly
{
    using CreateTeamMethods;
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using FormationTypes;
    using System.Collections.Generic;
    using System.Linq;

    public class FootballTeam
    {
        private List<FootballPlayer> _team;

        #region Constructors
        public FootballTeam()
        {
            _team = new List<FootballPlayer>();
        }

        public FootballTeam(bool generateRandomTeam)
            : this()
        {
            if (generateRandomTeam)
            {
                this.Team = CreateFootballTeam
                    .CreateARandomFootballTeam();
            }
        }

        public FootballTeam(FormationType formation)
            : this()

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
                var output =
                    new List<FootballPlayer>().ToArray();

                _team.CopyTo(output);

                return output.ToList();
            }
            private set { _team = value; }
        }
        #endregion

        public void CreateTeam(FormationType formation)
        {
            this.Team = CreateFootballTeam
                .CreateAFootballTeamByFormation(formation);
        }
        
    }
}
