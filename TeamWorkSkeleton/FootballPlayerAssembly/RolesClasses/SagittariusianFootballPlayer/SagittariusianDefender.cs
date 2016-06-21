using FootballPlayerAssembly.SpeciesAbstractClasses;

namespace FootballPlayerAssembly.RolesClasses.SagittariusianFootballPlayer
{
    public static partial class FootballPlayerFactory
    {
        internal class SagittariusianDefender:Sagittariusian
        {
            internal SagittariusianDefender(FootballPlayerFactoryClasses.GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer player) 
                : base(player)
            {
            }

            public SagittariusianDefender(GenericFootballPlayer player) : base(player)
            {
            }

            public SagittariusianDefender(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
