namespace TeamWork.Models.Abstract
{
    using Factory.Models.Generic;
    using Global.Contracts;
    using Global.DataStructures;
    using Global.Randomization;
    using System.Text;
    using System.Windows.Shapes;

    /// <summary>
    /// All Stats and methods for each type of FootballPlayer inheritor
    /// TODO: Prop Validation
    /// </summary>
    public abstract partial class FootballPlayer
        : IFootballPlayer
    {
        private static readonly Dice DiceOne;
        private static readonly Dice DiceTwo;

        static FootballPlayer()
        {
            DiceOne = new Dice(6);
            DiceTwo = new Dice(6);
        }

        // Simple Constructor
        internal FootballPlayer(string name)
        {
            this.Name = name;
            this.GetPlanetAndPositionTypes();
            this.InitVisualToken();
        }

        internal FootballPlayer(FootballPlayerFactory.GenericFootballPlayer player)
            : this(player.Name, player.StatPass, player.StatShoot, player.StatDribble,
                  player.StatSave, player.StatTackle, player.StatInterception, player.AwarenessRange, player.ActionPoints)
        {
        }

        internal FootballPlayer(string name,
            int pass, int shoot, int dribble,
            int save, int tackle, int interception,
            int awareness, int actionPoints)
            : this(name)
        {
            this.StatPass = pass;
            this.StatShoot = shoot;
            this.StatDribble = dribble;

            this.StatSave = save;
            this.StatTackle = tackle;
            this.StatInterception = interception;

            this.AwarenessRange = awareness;
            this.ActionPoints = actionPoints;
            this.CurrentAP = this.ActionPoints;
        }
        // Full Constructor

        public string Name { get; internal set; }
        // Offensive
        public int StatPass { get; protected set; }
        public int StatShoot { get; protected set; }
        public int StatDribble { get; protected set; }
        // Defensive
        public int StatSave { get; protected set; }
        public int StatTackle { get; protected set; }
        public int StatInterception { get; protected set; }
        // Game Mechanics
        public int AwarenessRange { get; protected set; }
        public int ActionPoints { get; protected set; }
        public int CurrentAP { get; private set; }

        public string Planet { get; private set; }
        public string Position { get; private set; }

        public PositionXY FieldPosition { get; set; }
        public PositionXY GridPosition { get; set; }
        public Ellipse VisualToken { get; set; }
        public int? CanvasChildIndex { get; set; }

        public bool HasBall { get; set; }
        public bool IsSelected { get; set; }
        public bool IsTargeted { get; set; }


        private void GetPlanetAndPositionTypes()
        {
            var planetBuilder = new StringBuilder();

            var type = this.GetType().Name;

            planetBuilder.Append(type[0]);

            var typeLenght = type.Length;
            for (var i = 1; i < typeLenght; i++)
            {
                if (char.IsUpper(type[i]))
                {
                    break;
                }
                else
                {
                    planetBuilder.Append(type[i]);
                }
            }

            this.Planet = planetBuilder.ToString();
            this.Position = type.Replace(this.Planet, "");
        }
    }
}
