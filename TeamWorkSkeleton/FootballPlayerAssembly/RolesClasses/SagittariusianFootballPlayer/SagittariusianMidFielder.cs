namespace FootballPlayerAssembly.RolesClasses.SagittariusianFootballPlayer
{
    using SpeciesAbstractClasses;

    public static partial class FootballPlayerFactory
    {
        internal class SagittariusianMidfielder:Sagittariusian
        {
            public SagittariusianMidfielder(string name) : base(name)
            {
            }

            public SagittariusianMidfielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }

            internal SagittariusianMidfielder(FootballPlayerFactoryClasses.GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer player) 
                : base(player)
            {
            }
        }
    }
}
