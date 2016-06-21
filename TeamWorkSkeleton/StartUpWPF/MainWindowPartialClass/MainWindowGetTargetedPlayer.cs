namespace StartUpWPF
{
    using GameStateTrackerAssembly;
    using System;

    public partial class MainWindow
    {
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
    }
}
