namespace FootballPlayerAssembly.RolesClasses.MercurianFootballPlayer
{
    using SpeciesAbstractClasses;
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class MercurianDefender : Mercurian
        {
            internal MercurianDefender(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer
                    player)
                : base(player)
            {
            }

            internal MercurianDefender(string name) : base(name)
            {
            }

            internal MercurianDefender(string name, int pass, int shoot, int dribble, int save, int tackle,
                int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }

}
