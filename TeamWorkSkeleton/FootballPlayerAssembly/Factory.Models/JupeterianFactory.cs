﻿namespace TeamWork.Models.Factory.Models
{
    using Abstract;
    using Global.Contracts;
    using Species.NameGenerator;

    public partial class FootballPlayerFactory
    {
        /// <summary>
        /// Creates a new Jupiterian player object 
        /// applying previously generated set of base 
        /// FootballPlayer base abstract stats
        /// wrapped in a GenericFootballPlayer object
        /// </summary>
        /// <param name="baseStats"> 
        /// set of stats wrapped in a GenericFootballPlayer object 
        /// </param>
        /// <returns>new Jupiterian(Position) object</returns>
        private FootballPlayer CreateJupiterianAttacker
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.JupiterianFootballPlayer.FootballPlayerFactory
                .JupiterianAttacker(baseStats);
            newPlayer.Name = GetJupiterianName();
            return newPlayer;
        }

        private FootballPlayer CreateJupiterianDefender
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.JupiterianFootballPlayer.FootballPlayerFactory
                .JupiterianDefender(baseStats);
            newPlayer.Name = GetJupiterianName();
            return newPlayer;
        }

        private FootballPlayer CreateJupiterianMidfielder
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.JupiterianFootballPlayer.FootballPlayerFactory
                .JupiterianMidfielder(baseStats);
            newPlayer.Name = GetJupiterianName();
            return newPlayer;
        }

        private FootballPlayer CreateJupiterianGoalkeeper
            (IFootballPlayer baseStats)
        {
            var newPlayer = new Roles.JupiterianFootballPlayer.FootballPlayerFactory
                .JupiterianGoalkeeper(baseStats);
            newPlayer.Name = GetJupiterianName();
            return newPlayer;
        }

        private string GetJupiterianName()
        {
            return JupiterianNameGenerator.GenerateName();
        }
    }
}
