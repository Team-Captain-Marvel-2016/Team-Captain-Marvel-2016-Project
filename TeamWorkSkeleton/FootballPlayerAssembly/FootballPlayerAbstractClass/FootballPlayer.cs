namespace FootballPlayerAssembly.FootballPlayerAbstractClass
{
    using FootballPlayerFactoryClasses.GenericFootballPlayerClasses;
    using GlobalDataStructures;
    using System.Text;
    using System.Windows.Shapes;
    using VisualizationInterfacesAssembly.CanvasVisualizationInterfaces;
    /// <summary>
    /// All Stats and methods for each type of FootballPlayer inheritor
    /// TODO: Prop Validation
    /// TODO: Implement Interfaces
    /// </summary>

    public abstract class FootballPlayer : IDrawOnCanvas
    {
        #region Constructors
        // Simple Constructor
        internal FootballPlayer(string name)
        {
            Name = name;

            this.GetPlanetAndPositionTypes();

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
            StatPass = pass;
            StatShoot = shoot;
            StatDribble = dribble;

            StatSave = save;
            StatTackle = tackle;
            StatInterception = interception;

            AwarenessRange = awareness;
            ActionPoints = actionPoints;
        }
        // Full Constructor
        #endregion

        #region Properties // TODO: Validation
        public string Name { get; protected set; }
        // Offensive
        public int StatPass { get; protected set; }
        public int StatShoot { get; protected set; }
        public int StatDribble { get; protected set; }
        // Defensive
        public int StatSave { get; protected set; }
        public int StatTackle { get; protected set; }
        public int StatInterception { get; protected set; }

        public int AwarenessRange { get; protected set; }
        public int ActionPoints { get; protected set; }
        
        public string Planet { get; private set; }
        public string Position { get; private set; }

        public PositionXY FieldPosition { get; set; }
        public PositionXY GridPosition { get; set; }
        public Ellipse VisualToken { get; set; }
        public int? CanvasChildIndex { get; set; }

        #endregion
        
        private void GetPlanetAndPositionTypes()
        {
            this.VisualToken = new Ellipse() { Width = 15, Height = 15 };
            this.GridPosition = new PositionXY();
            this.FieldPosition = new PositionXY();

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
