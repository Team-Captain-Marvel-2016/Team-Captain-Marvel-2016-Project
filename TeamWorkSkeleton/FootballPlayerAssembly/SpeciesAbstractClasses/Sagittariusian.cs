using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballPlayerAssembly.FootballPlayerAbstractClass;
using FootballPlayerAssembly.FootballPlayerFactoryClasses.GenericFootballPlayerClasses;
using FootballPlayerAssembly.RolesClasses.SagittariusianFootballPlayer;

namespace FootballPlayerAssembly.SpeciesAbstractClasses
{
    internal abstract class Sagittariusian : FootballPlayer
    {
        private RolesClasses.SagittariusianFootballPlayer.FootballPlayerFactory.GenericFootballPlayer player;
        private FootballPlayerFactoryClasses.GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer player1;

        protected Sagittariusian(string name) : base(name)
        {

        }

        internal Sagittariusian(FootballPlayerFactoryClasses.FootballPlayerFactory.GenericFootballPlayer player) : base(player)
        {
        }

        protected Sagittariusian(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
        {
        }

        protected Sagittariusian(RolesClasses.SagittariusianFootballPlayer.FootballPlayerFactory.GenericFootballPlayer player)
        {
            this.player = player;
        }

        protected Sagittariusian(FootballPlayerFactoryClasses.GenericFootballPlayerClasses.FootballPlayerFactory.GenericFootballPlayer player1) : base()
        {
            this.player1 = player1;
        }
    }
}
