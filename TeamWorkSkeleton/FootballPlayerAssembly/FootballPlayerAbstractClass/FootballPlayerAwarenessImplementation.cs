namespace FootballPlayerAssembly.FootballPlayerAbstractClass
{
    using Interfaces;
    using PlayingFIeldAssembly;
    using System;

    public abstract partial class FootballPlayer : IAwareness
    {
        public bool HasObjectsInRange()
        {
            var playerRow = this.GridPosition.X;
            var playerCol = this.GridPosition.Y;

            for (var row = Math.Max(playerRow - 1, 0); row <= Math.Min(playerRow + 1, 8); row++)
            {
                for (var col = Math.Max(playerCol - 1, 0); col <= Math.Min(playerCol + 1, 14); col++)
                {
                    if (row == playerRow && col == playerCol)
                    {
                        continue;
                    }
                    else if (PlayingField.Field[row, col])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
