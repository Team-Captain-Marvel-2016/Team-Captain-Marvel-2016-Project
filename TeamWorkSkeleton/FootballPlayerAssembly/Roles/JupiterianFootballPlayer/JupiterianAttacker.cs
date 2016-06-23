namespace FootballPlayerAssembly.RolesClasses.JupiterianFootballPlayer
{
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class JupiterianAttacker : Jupiterian
        {
            internal JupiterianAttacker(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player)
                : base(player)
            {
            }

            internal JupiterianAttacker(string name) : base(name)
            {
            }

            internal JupiterianAttacker(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
