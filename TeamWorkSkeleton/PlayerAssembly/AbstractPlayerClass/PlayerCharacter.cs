namespace PlayerAssembly.AbstractPlayerClass
{
    using System;
    using TeamAssembly;

    public abstract class PlayerCharacter
    {
        private string _name;

        protected PlayerCharacter(string name, string teamName)
        {
            this.Name = name;

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

        public FootballTeam Team { get; }

        #endregion

        public void CreateTeam(string name)
        {
            this.Team.CreateTeam();
        }
    }
}
