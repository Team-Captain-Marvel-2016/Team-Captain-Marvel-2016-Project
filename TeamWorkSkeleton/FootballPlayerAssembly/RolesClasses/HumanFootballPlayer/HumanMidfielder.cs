namespace FootballPlayerAssembly.RolesClasses.HumanFootballPlayer
{
    using FootballPlayerAssembly.SpeciesAbstractClasses;

    public  partial class FootballPlayerFactory
    {
        internal class HumanMidfielder : Human
        {
            internal HumanMidfielder(string name) : base(name)
            {
            }

            internal HumanMidfielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
