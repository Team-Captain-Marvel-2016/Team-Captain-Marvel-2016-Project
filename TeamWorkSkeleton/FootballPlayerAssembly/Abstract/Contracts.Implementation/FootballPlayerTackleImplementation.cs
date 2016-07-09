namespace TeamWork.Models.Abstract
{
    using Global.Contracts.Statistics;

    public abstract partial class FootballPlayer
    {
        public bool Tackle(IOffenseStats enemy)
        {
            var thisTackleRoll = DiceOne.Roll() + DiceTwo.Roll() + this.StatTackle;
            var enemyDribbleRoll = DiceOne.Roll() + DiceTwo.Roll() + enemy.StatDribble;

            while (thisTackleRoll == enemyDribbleRoll)
            {
                thisTackleRoll += DiceOne.Roll();
                enemyDribbleRoll += DiceTwo.Roll();
            }

            return thisTackleRoll > enemyDribbleRoll;
        }
    }
}
