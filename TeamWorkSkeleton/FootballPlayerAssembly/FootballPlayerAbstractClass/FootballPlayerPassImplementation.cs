namespace FootballPlayerAssembly.FootballPlayerAbstractClass
{
    using System;
    using GameLogicInterfacesAssembly;

    public abstract partial class FootballPlayer : IPass
    {
        public bool Pass(object e)
        {
            var enemy = e as FootballPlayer;

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
