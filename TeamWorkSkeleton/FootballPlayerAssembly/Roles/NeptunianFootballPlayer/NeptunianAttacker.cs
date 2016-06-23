namespace TeamWork.Models.Roles.NeptunianFootballPlayer
{
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class NeptunianAttacker : Neptunian
        {
            internal NeptunianAttacker(string name)
                : base(name)
            {
            }

            internal NeptunianAttacker(Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) 
                : base(player)
            {
            }

            internal NeptunianAttacker(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}