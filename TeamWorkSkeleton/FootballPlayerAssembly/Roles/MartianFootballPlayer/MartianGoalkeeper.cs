namespace FootballPlayerAssembly.RolesClasses.MartianFootballPlayer
{
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class MartianGoalkeeper : Martian
        {
            internal MartianGoalkeeper(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player)
                : base(player)
            {
            }

            internal MartianGoalkeeper(string name) : base(name)
            {
            }

            internal MartianGoalkeeper(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
