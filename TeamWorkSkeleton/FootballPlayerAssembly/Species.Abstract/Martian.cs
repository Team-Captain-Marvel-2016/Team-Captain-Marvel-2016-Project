namespace TeamWork.Models.Species.Abstract
{
    using TeamWork.Models.Factory.Models.Generic;
    using FootballPlayer = Models.Abstract.FootballPlayer;

    internal abstract class Martian : FootballPlayer
    {
        protected Martian(string name) : base(name)
        {
        }

        protected Martian(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
            : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
        {
        }

        internal Martian(FootballPlayerFactory.GenericFootballPlayer player) 
            : base(player)
        {
        }
    }
}
