namespace TeamWork.Models.Roles.UranianFootballPlayer
{
    using Global.Contracts;
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class UranianMidfielder : Venusian
        {
            internal UranianMidfielder(string name)
                : base(name)
            {
            }

            internal UranianMidfielder(IFootballPlayer player) 
                : base(player)
            {
            }

            internal UranianMidfielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}