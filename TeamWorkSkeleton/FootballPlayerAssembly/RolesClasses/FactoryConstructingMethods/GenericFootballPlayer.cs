namespace FootballPlayerAssembly.RolesClasses.FactoryConstructingMethods
{
    using FootballPlayerAbstractClass;
    public static partial class FootballPlayerFactory
    {
        /// <summary>
        /// Generic FootballPlayer inheritor,
        /// to simplify moving data down the assembly line 
        /// ( between methods ).
        /// </summary>
        internal class GenericFootballPlayer : FootballPlayer
        {
            public GenericFootballPlayer()
                : base()
            {
            }
        }
    }
}
