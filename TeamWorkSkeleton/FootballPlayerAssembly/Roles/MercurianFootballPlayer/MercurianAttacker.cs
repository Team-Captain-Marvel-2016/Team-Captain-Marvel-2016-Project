﻿namespace FootballPlayerAssembly.RolesClasses.MercurianFootballPlayer
{
    using SpeciesAbstractClasses;
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class MercurianAttacker : Mercurian
        {
            internal MercurianAttacker(
                TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer
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