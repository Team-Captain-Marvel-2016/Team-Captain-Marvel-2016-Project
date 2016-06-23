namespace TeamWork.Models.Roles.HumanFootballPlayer
{
    using TeamWork.Models.Species.Abstract;

    public  partial class FootballPlayerFactory
    {
        internal class HumanMidfielder : Human
        {
            internal HumanMidfielder(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player)
                : base(player)
            {
            }

            internal HumanMidfielder(string name) : base(name)
            {
            }

            internal HumanMidfielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
