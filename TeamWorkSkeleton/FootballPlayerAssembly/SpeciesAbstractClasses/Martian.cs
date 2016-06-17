namespace FootballPlayerAssembly.SpeciesAbstractClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FootballPlayerAbstractClass;

    internal abstract class Martian : FootballPlayer
    {
        protected Martian(string name) : base(name)
        {
        }

        protected Martian(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
        {
        }
    }
}
