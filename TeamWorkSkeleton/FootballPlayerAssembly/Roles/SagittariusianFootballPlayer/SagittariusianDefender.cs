namespace TeamWork.Models.Roles.SagittariusianFootballPlayer
{
    using Global.Contracts;
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class SagittariusianDefender : Sagittariusian
        {
            public SagittariusianDefender(string name) 
                : base(name)
            {
            }

            public SagittariusianDefender(IFootballPlayer player)
                : base(player)
            {
            }

            public SagittariusianDefender(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
