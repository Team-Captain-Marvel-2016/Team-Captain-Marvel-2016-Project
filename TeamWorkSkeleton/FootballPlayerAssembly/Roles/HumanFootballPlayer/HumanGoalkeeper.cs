namespace FootballPlayerAssembly.RolesClasses.HumanFootballPlayer
{
    using FootballPlayerAssembly.SpeciesAbstractClasses;
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class HumanGoalkeeper : Human
        {
            internal HumanGoalkeeper(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) 
                : base(player)
            {
            }

            internal HumanGoalkeeper(string name) : base(name)
            {
            }

            internal HumanGoalkeeper(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}