namespace TeamWork.Models.Roles.MercurianFootballPlayer
{
    using Global.Contracts;
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class MercurianDefender : Mercurian
        {
            internal MercurianDefender(string name) 
                : base(name)
            {
            }

            internal MercurianDefender(IFootballPlayer player)
                : base(player)
            {
            }

            internal MercurianDefender(string name, int pass, int shoot, int dribble, int save, int tackle,
                int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }

}
