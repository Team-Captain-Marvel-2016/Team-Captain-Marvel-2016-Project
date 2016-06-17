namespace FootballPlayerAssembly.RolesClasses.MartianFootballPlayer
{
    using FootballPlayerAssembly.SpeciesAbstractClasses;

    public static partial class FootballPlayerFactory
    {
        internal class MartianAttacker : Martian
        {
            internal MartianAttacker(string name) : base(name)
            {
            }

            internal MartianAttacker(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
