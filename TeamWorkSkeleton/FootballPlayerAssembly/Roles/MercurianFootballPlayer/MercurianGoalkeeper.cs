namespace TeamWork.Models.Roles.MercurianFootballPlayer
{
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class MercurianGoalkeeper : Mercurian
        {
            internal MercurianGoalkeeper(string name) 
                : base(name)
            {
            }

            internal MercurianGoalkeeper(Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) : base(player)
            {
            }

            internal MercurianGoalkeeper(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
    
}
