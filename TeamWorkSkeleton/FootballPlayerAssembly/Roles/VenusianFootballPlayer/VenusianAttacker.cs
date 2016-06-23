namespace FootballPlayerAssembly.RolesClasses.VenusianFootballPlayer
{
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class VenusianAttacker : Venusian
        {
            internal VenusianAttacker(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) 
                : base(player)
            {
            }

            internal VenusianAttacker(string name) 
                : base(name)
            {
            }

            internal VenusianAttacker(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}