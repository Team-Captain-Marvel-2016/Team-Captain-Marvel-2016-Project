namespace FootballPlayerAssembly.RolesClasses.SagittariusianFootballPlayer
{
    using FootballPlayerAssembly.SpeciesAbstractClasses;

    public static partial class FootballPlayerFactory
    {
        internal class SagittariusianGoalkeeper : Sagittariusian
        {
            public SagittariusianGoalkeeper(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) : base(player)
            {
            }

            public SagittariusianGoalkeeper(string name) : base(name)
            {
            }

            public SagittariusianGoalkeeper(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
