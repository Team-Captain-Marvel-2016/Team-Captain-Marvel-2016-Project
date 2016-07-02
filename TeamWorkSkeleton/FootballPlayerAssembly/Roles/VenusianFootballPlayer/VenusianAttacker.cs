namespace TeamWork.Models.Roles.VenusianFootballPlayer
{
    using Global.Contracts;
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class VenusianAttacker : Venusian
        {
            internal VenusianAttacker(string name)
                : base(name)
            {
            }

            internal VenusianAttacker(IFootballPlayer player) 
                : base(player)
            {
            }

            internal VenusianAttacker(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}