namespace TeamAssembly
{
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using FormationTypes;
    using System.Collections.Generic;

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
                // GenerateRandomTeam
            }
        }

        public FootballTeam(FormationType formation)
            : this()

        {
            // Generate Team by given formation
        }
        #endregion

        public List<FootballPlayer> Team
        {
            get { return _team; }
            private set { _team = value; }
        }
    }
}
