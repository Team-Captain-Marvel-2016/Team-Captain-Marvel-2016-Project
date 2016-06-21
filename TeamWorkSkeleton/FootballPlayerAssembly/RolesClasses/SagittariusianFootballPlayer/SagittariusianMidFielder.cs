using FootballPlayerAssembly.SpeciesAbstractClasses;

namespace FootballPlayerAssembly.RolesClasses.SagittariusianFootballPlayer
{
    public static partial class FootballPlayerFactory
    {
        internal class SagittariusianMidFielder:Sagittariusian
        {
            public SagittariusianMidFielder(string name) : base(name)
            {
            }

            public SagittariusianMidFielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }

            internal SagittariusianMidFielder(FootballPlayerFactoryClasses.GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer player) 
                : base(player)
            {
            }
        }
    }
}
