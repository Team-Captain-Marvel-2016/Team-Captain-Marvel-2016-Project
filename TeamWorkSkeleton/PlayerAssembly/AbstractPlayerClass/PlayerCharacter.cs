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

        #endregion

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
