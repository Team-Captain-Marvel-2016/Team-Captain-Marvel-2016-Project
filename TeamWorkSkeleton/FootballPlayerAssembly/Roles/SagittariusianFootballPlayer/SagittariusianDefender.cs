using FootballPlayerAssembly.SpeciesAbstractClasses;

namespace FootballPlayerAssembly.RolesClasses.SagittariusianFootballPlayer
{
    public static partial class FootballPlayerFactory
    {
        internal class SagittariusianDefender : Sagittariusian
        {
            public SagittariusianDefender(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) : base(player)
            {
            }

            public SagittariusianDefender(string name) : base(name)
            {
            }

            public SagittariusianDefender(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
