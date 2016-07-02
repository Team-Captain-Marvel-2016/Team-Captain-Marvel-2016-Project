namespace TeamWork.Models.Roles.NeptunianFootballPlayer
{
    using Global.Contracts;
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class NeptunianDefender : Neptunian
        {
            internal NeptunianDefender(string name)
                : base(name)
            {
            }

            internal NeptunianDefender(IFootballPlayer player) 
                : base(player)
            {
            }

            internal NeptunianDefender(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}