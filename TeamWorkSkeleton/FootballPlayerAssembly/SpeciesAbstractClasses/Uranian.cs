namespace FootballPlayerAssembly.SpeciesAbstractClasses
{
    using FootballPlayerAbstractClass;
    using FootballPlayerFactoryClasses.GenericFootballPlayerClasses;

    public class Uranian : FootballPlayer
    {
        protected Uranian(string name)
            : base(name)
        {
        }

        protected Uranian(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
            : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
        {
        }

        internal Uranian(FootballPlayerFactory.GenericFootballPlayer player)
            : base(player)
        {
        }
    }
}