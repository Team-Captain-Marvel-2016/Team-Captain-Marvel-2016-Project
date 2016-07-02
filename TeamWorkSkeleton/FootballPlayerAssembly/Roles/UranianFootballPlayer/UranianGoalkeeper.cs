namespace TeamWork.Models.Roles.UranianFootballPlayer
{
    using Global.Contracts;
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class UranianGoalkeeper : Uranian
        {
            internal UranianGoalkeeper(string name)
                : base(name)
            {
            }

            internal UranianGoalkeeper(IFootballPlayer player) 
                : base(player)
            {
            }

            internal UranianGoalkeeper(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}