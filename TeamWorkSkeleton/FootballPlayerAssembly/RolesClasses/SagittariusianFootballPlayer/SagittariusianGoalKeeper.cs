using FootballPlayerAssembly.SpeciesAbstractClasses;

namespace FootballPlayerAssembly.RolesClasses.SagittariusianFootballPlayer
{
    public static partial class FootballPlayerFactory
    {
       internal  class SagittariusianGoalKeeper: Sagittariusian
        {

           public SagittariusianGoalKeeper(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
           {
           }

           public SagittariusianGoalKeeper(GenericFootballPlayer player) : base(player)
           {
           }

            internal SagittariusianGoalKeeper(FootballPlayerFactoryClasses.GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer player) 
                : base(player)
            {
            }
        }
    }
}
