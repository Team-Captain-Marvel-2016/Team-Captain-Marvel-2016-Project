namespace FootballPlayerAssembly.RolesClasses.MartianFootballPlayer
{
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class MartianDefender : Martian
        {
            internal MartianDefender(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) 
                : base(player)
            {
            }

            internal MartianDefender(string name) : base(name)
            {
            }

            internal MartianDefender(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
