namespace FootballPlayerAssembly.RolesClasses.MercurianFootballPlayer
{
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class MercurianMidfielder : Mercurian
        {
            internal MercurianMidfielder(
                TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) : base(player)
            {
            }

            internal MercurianMidfielder(string name) : base(name)
            {
            }

            internal MercurianMidfielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
    
}
