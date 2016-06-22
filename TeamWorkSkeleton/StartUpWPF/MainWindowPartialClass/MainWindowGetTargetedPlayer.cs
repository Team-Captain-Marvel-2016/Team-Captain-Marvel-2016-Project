namespace StartUpWPF
{
    using GameStateTrackerAssembly;
    using System;
    using FootballPlayer = TeamWork.Models.Abstract.FootballPlayer;

    public partial class MainWindow
    {
        /// <summary>
        /// Add methods handling Passes to MouseDown event
        /// </summary>
        private void AddMouseDownEventPass()
        {
            foreach (var footballPlayer in GameStateTracker.PlayerOnTurn.Team.Team)
            {
                footballPlayer.VisualToken.MouseDown += OnMouseDownPass;
            }
        }

        private void RemoveMouseDownEventPass()
        {
            foreach (var footballPlayer in GameStateTracker.PlayerOnTurn.Team.Team)
            {
                footballPlayer.VisualToken.MouseDown += OnMouseDownPass;
            }      
        }

        /// <summary>
        /// Add methods handling Tackle to MouseDown event
        /// </summary>
        private void AddMouseDownEventTackle(Func<object, EventArgs> func)
        {
            foreach (var footballPlayer in GameStateTracker.PlayerOnTurn.Team.Team)
            {
                footballPlayer.VisualToken.MouseDown += OnMouseDownTackle;
            }
        }

        private void RemoveMouseDownEventTackle()
        {
            foreach (var footballPlayer in GameStateTracker.PlayerOnTurn.Team.Team)
            {
                footballPlayer.VisualToken.MouseDown += OnMouseDownTackle;
            }
        }

        private FootballPlayer GetTargetPlayer(int index)
        {
            foreach (var footballPlayer in GameStateTracker.PlayerOnTurn.Team.Team)
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
