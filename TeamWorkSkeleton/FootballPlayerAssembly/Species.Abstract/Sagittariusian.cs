namespace FootballPlayerAssembly.SpeciesAbstractClasses
{
    using FootballPlayer = TeamWork.Models.Abstract.FootballPlayer;
    using FootballPlayerFactory = TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory;

    internal abstract class Sagittariusian : FootballPlayer
    {
        internal Sagittariusian(FootballPlayerFactory.GenericFootballPlayer player) : base(player)
        {
        }

        internal Sagittariusian(string name) 
            : base(name)
        {
        }

        internal Sagittariusian(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
            : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
        {
        }
    }
}
