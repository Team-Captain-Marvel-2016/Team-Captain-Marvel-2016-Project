namespace FootballPlayerAssembly.RolesClasses.VenusianFootballPlayer
{
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class VenusianDefender : Venusian
        {
            internal VenusianDefender(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) 
                : base(player)
            {
            }

            internal VenusianDefender(string name) 
                : base(name)
            {
            }

            internal VenusianDefender(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}