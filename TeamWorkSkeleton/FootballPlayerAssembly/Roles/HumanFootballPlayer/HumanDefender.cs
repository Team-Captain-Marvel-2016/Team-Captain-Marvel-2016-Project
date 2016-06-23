namespace FootballPlayerAssembly.RolesClasses.HumanFootballPlayer
{
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class HumanDefender : Human
        {
            internal HumanDefender(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player)
                : base(player)
            {
            }

            internal HumanDefender(string name) : base(name)
            {
            }

            internal HumanDefender(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
