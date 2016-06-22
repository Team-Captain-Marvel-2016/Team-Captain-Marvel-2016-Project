namespace FootballPlayerAssembly.RolesClasses.JupiterianFootballPlayer
{
    using SpeciesAbstractClasses;
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class JupiterianDefender : Jupiterian
        {
            internal JupiterianDefender(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player)
                : base(player)
            {
            }

            internal JupiterianDefender(string name) : base(name)
            {
            }

            internal JupiterianDefender(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
