namespace TeamWork.Models.Roles.SagittariusianFootballPlayer
{
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class SagittariusianAttacker : Sagittariusian
        {
            public SagittariusianAttacker(string name) 
                : base(name)
            {
            }

            public SagittariusianAttacker(Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) 
                : base(player)
            {
            }

            public SagittariusianAttacker(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
