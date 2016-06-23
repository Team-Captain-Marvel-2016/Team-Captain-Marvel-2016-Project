namespace Teamwork.Models.PC.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Media;
    using Global.DataStructures;
    using Global.Settings.Visualization;
    using TeamAssembly;
    using FootballPlayer = TeamWork.Models.Abstract.FootballPlayer;

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
            get { return this._name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name must have value");
                }
                else
                {
                    this._name = value;
                }
            }
        }

        public SolidColorBrush Color { get; protected set; }

        public FootballTeam Team { get; }

        public int CurrentPlayer { get; protected set; }

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
            this.ResetVisualTokenColor();
        }

        public void ResetVisualTokenColor()
        {
            foreach (var player in this.Team)
            {
                player.SetVisualTokenColor(this.Color);
            }
        }

        public void ResetVisualTokenSize()
        {
            var widthHeight = 
                FootballPlayerSettings.VisualTokenSize;
            
            foreach (var player in this.Team)
            {
                player.SetVisualTokenSize(widthHeight, widthHeight);
            }
        }

        public List<FootballPlayer> GetPlayersOnPositionsList(IEnumerable<PositionXY> positionsList)
        {
            var output = new List<FootballPlayer>();

            foreach (var xy in positionsList)
            {
                foreach (var footballPlayer in this.Team)
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
