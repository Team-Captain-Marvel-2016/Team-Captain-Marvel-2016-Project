namespace TeamWork.Models.Abstract
{
    using System;
    using GlobalInterfacesAssembly.GameLogicInterfaces;
    using GlobalInterfacesAssembly.StatsInterfaces;

    public abstract partial class FootballPlayer : IPass
    {
        public bool Pass(IDefenseStats enemy)
        {
            if (enemy == null) throw new ApplicationException("Invalid Argument");

            var thisScore = this.StatPass
                            + DiceOne.Roll()
                            + DiceTwo.Roll();

            var enemyScore = enemy.StatInterception
                             + DiceOne.Roll()
                             + DiceTwo.Roll();

            return thisScore >= enemyScore;
        }
    }
}
