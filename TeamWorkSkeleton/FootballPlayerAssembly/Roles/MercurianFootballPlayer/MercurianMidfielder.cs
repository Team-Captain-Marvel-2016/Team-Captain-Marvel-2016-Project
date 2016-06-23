namespace TeamWork.Models.Roles.MercurianFootballPlayer
{
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class MercurianMidfielder : Mercurian
        {
            internal MercurianMidfielder(string name)
                : base(name)
            {
            }

            internal MercurianMidfielder(Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) : base(player)
            {
            }

            internal MercurianMidfielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
    
}
