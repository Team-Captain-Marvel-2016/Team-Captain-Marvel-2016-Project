namespace TeamWork.Models.PC.Reimplementation.Models
{
    using System.Collections.Generic;
    using System.Windows.Media;
    using Contracts;
    using Global.Contracts;
    using Global.DataStructures;
    using Global.Enumerations.Team;
    using Global.Settings.Visualization;
    using TeamAssembly;

    public abstract class PlayerCharacter : IPlayerCharacter
    {
        protected PlayerCharacter(string name)
        {
            this.Name = name;

            this.InitializeTeam();
        }

        public string Name { get; protected set; }

        public ITeam Team { get; protected set; }

        public SolidColorBrush Color { get; set; }

        public int CurrentPlayer { get; protected set; }

        public void NextPlayer()
        {
            this.CurrentPlayer--;

            if (this.CurrentPlayer < 1)
            {
                this.CurrentPlayer = 5;
            }
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
            foreach (var player in this.Team)
            {
                player.SetVisualTokenSize(
                    FootballPlayerSettings.VisualTokenSize,
                    FootballPlayerSettings.VisualTokenSize);
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

        private void InitializeTeam()
        {
            this.Team = new FootballTeam(this.Name + " Team");
            this.Team.CreateTeam();
            this.CurrentPlayer = 5;
        }
    }
}