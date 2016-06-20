﻿namespace FootballPlayerAssembly.FootballPlayerAbstractClass
{
    using GameLogicInterfacesAssembly;
    using GlobalDataStructures;
    using PlayingFIeldAssembly;
    using System;

    public abstract partial class FootballPlayer : IControlMovement
    {
        public void MoveUp()
        {
            var currentRow = this.GridPosition.X;
            var currentCol = this.GridPosition.Y;

            var newRow = currentRow - 1;
            var newCol = currentCol;

            this.Move(newRow, newCol);
        }

        public void MoveDown()
        {
            var currentRow = this.GridPosition.X;
            var currentCol = this.GridPosition.Y;

            var newRow = currentRow + 1;
            var newCol = currentCol;

            this.Move(newRow, newCol);
        }

        public void MoveLeft()
        {
            var currentRow = this.GridPosition.X;
            var currentCol = this.GridPosition.Y;

            var newRow = currentRow;
            var newCol = currentCol - 1;

            this.Move(newRow, newCol);
        }

        public void MoveRight()
        {
            var currentRow = this.GridPosition.X;
            var currentCol = this.GridPosition.Y;

            var newRow = currentRow;
            var newCol = currentCol + 1;

            this.Move(newRow, newCol);
        }

        private void Move(int newRow, int newCol)
        {
            // Check Position Up
            if (CheckPosition(newRow, newCol))
            {
                throw new Exception("Position is not free");
            }
            // Adjust position
            else
            {
                this.ChangeGridPosition(newRow, newCol);
            }
        }

        private bool CheckPosition(int row, int col)
        {
            try
            {
                return PlayingField.Field[row, col];
            }
            catch (Exception)
            {
                return true; // Index out of range.
            }
        }

        private void ChangeGridPosition(int row, int col)
        {
            this.GridPosition = new PositionXY(row, col);
        }
    }
}
