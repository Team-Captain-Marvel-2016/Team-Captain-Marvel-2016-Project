namespace TeamWork.Models.Roles.JupiterianFootballPlayer
{
    using Global.Contracts;
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class JupiterianGoalkeeper : Jupiterian
        {
            internal JupiterianGoalkeeper(string name)
                : base(name)
            {
            }

            internal JupiterianGoalkeeper(IFootballPlayer player)
                : base(player)
            {
            }

            internal JupiterianGoalkeeper(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
