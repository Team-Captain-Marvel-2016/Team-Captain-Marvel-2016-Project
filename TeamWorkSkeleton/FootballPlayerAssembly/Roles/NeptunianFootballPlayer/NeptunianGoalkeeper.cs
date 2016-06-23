namespace TeamWork.Models.Roles.NeptunianFootballPlayer
{
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class NeptunianGoalkeeper : Neptunian
        {
            internal NeptunianGoalkeeper(string name)
                : base(name)
            {
            }

            internal NeptunianGoalkeeper(Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) : base(player)
            {
            }

            internal NeptunianGoalkeeper(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}