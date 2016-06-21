namespace FootballPlayerAssembly.RolesClasses.UranianFootballPlayer
{
    using FootballPlayerFactoryClasses.GenericFootballPlayerClasses;
    using SpeciesAbstractClasses;

    public static partial class FootballPlayerFactory
    {
        internal class UranianMidfielder : Venusian
        {
            internal UranianMidfielder(FootballPlayerFactoryClasses.GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer player) : base(player)
            {
            }

            internal UranianMidfielder(string name)
                : base(name)
            {
            }

            internal UranianMidfielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}