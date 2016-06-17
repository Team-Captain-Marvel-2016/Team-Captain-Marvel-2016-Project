namespace FootballPlayerAssembly.SpeciesAbstractClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FootballPlayerAbstractClass;
    using FootballPlayerFactoryClasses.GenericFootballPlayerClasses;

    internal abstract class Human : FootballPlayer
    {
        protected Human(string name) : base(name)
        {
        }

        protected Human(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
            : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
        {
        }

        internal Human(FootballPlayerFactory.GenericFootballPlayer player) 
            : base(player)
        {
        }
    }
}
