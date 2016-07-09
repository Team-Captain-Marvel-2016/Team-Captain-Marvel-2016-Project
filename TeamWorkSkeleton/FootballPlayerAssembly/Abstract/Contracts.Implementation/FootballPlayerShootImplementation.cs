namespace TeamWork.Models.Abstract
{
    using System;
    using Global.Contracts.Actions;
    using Global.Contracts.Statistics;

    public abstract partial class FootballPlayer : IShoot
    {
        public bool Shoot(IDefenseStats enemy)
        {
            if (enemy == null) throw new ApplicationException("Invalid Argument");

            var thisScore = this.StatShoot
                            + DiceOne.Roll()
                            + DiceTwo.Roll()
                            + DiceOne.Roll();

            var enemyScore = enemy.StatSave
                             + DiceTwo.Roll()
                             + DiceOne.Roll();

            bool isGoal = thisScore > enemyScore;

            if (isGoal)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

