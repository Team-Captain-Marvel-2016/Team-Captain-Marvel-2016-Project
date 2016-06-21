using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballPlayerAssembly.FootballPlayerFactoryClasses.GenericFootballPlayerClasses;
using FootballPlayerAssembly.SpeciesAbstractClasses;

namespace FootballPlayerAssembly.RolesClasses.SagittariusianFootballPlayer
{
    using SpeciesAbstractClasses;


    public static partial class FootballPlayerFactory
    {
        public class GenericFootballPlayer
        {
        }

        internal class SagittariusianAttacker : Sagittariusian
        {
            public SagittariusianAttacker(string name) : base(name)
            {
            }

            public SagittariusianAttacker(FootballPlayerFactory.GenericFootballPlayer player) : base(player)
            {
            }

            public SagittariusianAttacker(string name, int pass, int shoot, int dribble, int save, int tackle,
                int interception, int awareness, int actionPoints) :
                    base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
