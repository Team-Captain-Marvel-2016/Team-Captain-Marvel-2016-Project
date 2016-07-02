namespace TeamWork.Models.Species.Abstract
{
    using Global.Contracts;
    using Models.Abstract;

    internal class Venusian : FootballPlayer
    {
        protected Venusian(string name)
            : base(name)
        {
        }

        protected Venusian(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
            : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
        {
        }

        internal Venusian(IFootballPlayer player) 
            : base(player)
        {
        }
    }
}
