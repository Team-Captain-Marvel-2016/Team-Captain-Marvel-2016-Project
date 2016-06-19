namespace PlayerAssembly.AbstractPlayerClass
{
    using System;
    using System.Windows.Media;
    using TeamAssembly;

    public abstract class PlayerCharacter
    {
        private string _name;

        protected PlayerCharacter(string name, string teamName, SolidColorBrush color)
        {
            this.Name = name;
            this.Color = color;
            this.Team = new FootballTeam(teamName);
            this.CurrentPlayer = 5;
        }
        
        #region Properties
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name must have value");
                }
                else
                {
                    _name = value;
                }
            }
        }

        protected SolidColorBrush Color { get; set; }

        public FootballTeam Team { get; }

        public int CurrentPlayer { get; set; }

        #endregion

        public void NextPlayer()
        {
            this.CurrentPlayer++;

            if (this.CurrentPlayer > 5)
            {
                this.CurrentPlayer = 1;
            }
        }

        public void CreateTeam(string name)
        {
            this.Team.CreateTeam();
            this.AssignTeamColor();
        }

        private void AssignTeamColor()
        {
            foreach (var player in this.Team)
            {
                player.VisualToken.Fill = this.Color;
            }
        }
    }
}
