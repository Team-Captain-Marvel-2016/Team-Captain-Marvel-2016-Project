namespace FootballPlayerAssembly.RolesClasses.NeptunianFootballPlayer
{
    using FootballPlayerFactoryClasses.GenericFootballPlayerClasses;
    using SpeciesAbstractClasses;

    public static partial class FootballPlayerFactory
    {
        internal class NeptunianMidfielder : Neptunian
        {
            internal NeptunianMidfielder(FootballPlayerFactoryClasses.GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer player) : base(player)
            {
            }

            internal NeptunianMidfielder(string name)
                : base(name)
            {
            }

            internal NeptunianMidfielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}