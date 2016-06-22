namespace FootballPlayerAssembly.RolesClasses.UranianFootballPlayer
{
    using SpeciesAbstractClasses;
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class UranianAttacker : Uranian
        {
            internal UranianAttacker(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) 
                : base(player)
            {
            }

            internal UranianAttacker(string name) 
                : base(name)
            {
            }

            internal UranianAttacker(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}