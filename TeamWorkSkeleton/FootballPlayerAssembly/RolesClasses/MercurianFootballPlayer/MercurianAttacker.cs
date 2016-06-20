﻿namespace FootballPlayerAssembly.RolesClasses.MercurianFootballPlayer
{
    using FootballPlayerFactoryClasses.GenericFootballPlayerClasses;
    using FootballPlayerAssembly.SpeciesAbstractClasses;

    public static partial class FootballPlayerFactory
    {
        internal class MercurianAttacker : Mercurian
        {
            internal MercurianAttacker(
                FootballPlayerFactoryClasses.GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer
                    player) : base(player)
            {
            }

            internal MercurianAttacker(string name) : base(name)
            {
            }

            internal MercurianAttacker(string name, int pass, int shoot, int dribble, int save, int tackle,
                int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
    
}