namespace FootballPlayerAssembly.SpeciesAbstractClasses
{
    using FootballPlayerAbstractClass;
    using FootballPlayerFactoryClasses;
    using FootballPlayerFactoryClasses.GenericFootballPlayerClasses;

    internal abstract class Sagittariusian : FootballPlayer
    {
        internal Sagittariusian(FootballPlayerFactoryClasses.GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer player) : base(player)
        {
        }

        internal Sagittariusian(string name) 
            : base(name)
        {
        }

        internal Sagittariusian(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
            : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
        {
        }
    }
}
