namespace FootballPlayerAssembly.RolesClasses.NeptunianFootballPlayer
{
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class NeptunianGoalkeeper : Neptunian
        {
            internal NeptunianGoalkeeper(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) : base(player)
            {
            }

            internal NeptunianGoalkeeper(string name) 
                : base(name)
            {
            }

            internal NeptunianGoalkeeper(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}