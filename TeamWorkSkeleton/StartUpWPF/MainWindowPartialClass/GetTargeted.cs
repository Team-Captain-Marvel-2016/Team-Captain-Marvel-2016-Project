namespace StartUpWPF
{
    using Game.Tracker;
    using Global.Contracts;
    using System;
    
    public partial class MainWindow
    {
        /// <summary>
        /// Add methods handling Passes to MouseDown event
        /// </summary>
        private void AddMouseDownEventPass()
        {
            foreach (var footballPlayer in GameStateTracker.PlayerOnTurn.PlayerCharacter.Team.Team)
            {
                footballPlayer.VisualToken.MouseDown += OnMouseDownPass;
            }
        }

        private void RemoveMouseDownEventPass()
        {
            foreach (var footballPlayer in GameStateTracker.PlayerOnTurn.PlayerCharacter.Team.Team)
            {
                footballPlayer.VisualToken.MouseDown += OnMouseDownPass;
            }      
        }

        /// <summary>
        /// Searches for a football player object
        /// based on the Canvas Children index of its
        /// VisualToken.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private IFootballPlayer GetTargetPlayer(int index)
        {
            foreach (var footballPlayer in GameStateTracker.PlayerOnTurn.PlayerCharacter.Team.Team)
            {
                if (footballPlayer.CanvasChildIndex == index)
                {
                    return footballPlayer;
                }
            }

            throw new Exception("Target not found");
        }
    }
}
