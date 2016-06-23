namespace TeamWork.Models.Species.Abstract
{
    using Factory.Models.Generic;
    using Models.Abstract;

    internal class Uranian : FootballPlayer
    {
        public Uranian(string name)
            : base(name)
        {
        }

        public Uranian(FootballPlayerFactory.GenericFootballPlayer player) 
            : base(player)
        {
        }

        public Uranian(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
            : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
        {
        }
    }
}