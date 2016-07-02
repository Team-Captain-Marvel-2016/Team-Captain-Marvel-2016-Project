namespace TeamWork.Models.Roles.JupiterianFootballPlayer
{
    using Global.Contracts;
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class JupiterianMidfielder : Jupiterian
        {

            internal JupiterianMidfielder(string name)
                : base(name)
            {
            }

            internal JupiterianMidfielder(IFootballPlayer player)
                : base(player)
            {
            }

            internal JupiterianMidfielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
