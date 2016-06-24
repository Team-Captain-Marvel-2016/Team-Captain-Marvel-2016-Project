namespace Teamwork.Models.PC.Abstract
{
    using Global.Contracts;
    using Global.DataStructures;
    using Global.Settings.Visualization;
    using System;
    using System.Collections.Generic;
    using System.Windows.Media;
    using TeamAssembly;

    public abstract class PlayerCharacter
    {
        private string name;

        protected PlayerCharacter(string name, string teamName, SolidColorBrush color)
        {
            this.Name = name;
            this.Color = color;
            this.Team = new FootballTeam(teamName);
            this.CurrentPlayer = 5;
        }
        
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name must have value");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public SolidColorBrush Color { get; protected set; }

        public ITeam Team { get; }

        public int CurrentPlayer { get; protected set; }
        
        public void NextPlayer()
        {
            this.CurrentPlayer++;

            if (this.CurrentPlayer > 5)
            {
                this.CurrentPlayer = 1;
            }
        }

        public void CreateTeam(string teamName)
        {
            this.Team.CreateTeam();
            this.Team.SetTeamName(teamName);
            this.ResetVisualTokenColor();
        }

        public void ResetVisualTokenColor()
        {
            foreach (var player in this.Team.Team)
            {
                player.SetVisualTokenColor(this.Color);
            }
        }

        public void ResetVisualTokenSize()
        {
            var widthHeight = 
                FootballPlayerSettings.VisualTokenSize;
            
            foreach (var player in this.Team.Team)
            {
                player.SetVisualTokenSize(widthHeight, widthHeight);
            }
        }

        public List<IFootballPlayer> GetPlayersOnPositionsList(IEnumerable<PositionXY> positionsList)
        {
            var output = new List<IFootballPlayer>();

            foreach (var xy in positionsList)
            {
                foreach (var footballPlayer in this.Team.Team)
                {
                    if (xy.X == footballPlayer.GridPosition.X && xy.Y == footballPlayer.GridPosition.Y)
                    {
                        output.Add(footballPlayer);
                    }
                }
            }

            return output;
        }
    }
}
