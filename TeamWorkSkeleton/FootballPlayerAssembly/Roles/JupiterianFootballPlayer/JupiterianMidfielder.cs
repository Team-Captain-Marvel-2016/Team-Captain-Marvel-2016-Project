namespace FootballPlayerAssembly.RolesClasses.JupiterianFootballPlayer
{
    using SpeciesAbstractClasses;
    using TeamWork.Models.Species.Abstract;

    public partial class FootballPlayerFactory
    {
        internal class JupiterianMidfielder : Jupiterian
        {
            internal JupiterianMidfielder(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player)
                : base(player)
            {
            }

            internal JupiterianMidfielder(string name) : base(name)
            {
            }

            internal JupiterianMidfielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
