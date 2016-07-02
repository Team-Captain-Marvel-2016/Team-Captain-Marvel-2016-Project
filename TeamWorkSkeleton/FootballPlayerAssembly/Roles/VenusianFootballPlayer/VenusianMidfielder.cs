namespace TeamWork.Models.Roles.VenusianFootballPlayer
{
    using Global.Contracts;
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class VenusianMidfielder : Venusian
        {
            internal VenusianMidfielder(string name)
                : base(name)
            {
            }

            internal VenusianMidfielder(IFootballPlayer player)
                : base(player)
            {
            }

            internal VenusianMidfielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}