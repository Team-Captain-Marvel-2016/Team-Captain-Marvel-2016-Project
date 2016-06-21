
using System.Windows.Media;

namespace StartUpWPF
{
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using GameStateTrackerAssembly;
    using System;
    using System.Windows;
    using System.Windows.Shapes;
    
    public partial class MainWindow
    {
        private delegate void OnMouseDownAdd(object sender, EventArgs args);

        private void PassBtn_OnClick(object sender, RoutedEventArgs e)
        {
            // Select Target.
            // Add MouseDownEvents to All Players.
            // On click -> remove those events.
            AddMouseDownEventPass();
            }

        private void CallForPassBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnMouseDownPass(object sender, EventArgs args)
        {
            // Remove Event.
            RemoveMouseDownEventPass();

            // Find the target player by CanvasChildIndex based on the sender object.
            var childIndex = PlayFieldCanvas.Children.IndexOf((Ellipse)sender);
            var target = GetTargetPlayer(childIndex);

            // Check Path of the Ball.

            // Roll Dice / Do calculation.

            // Transfer the ball to friendly/ enemy.

            // Update visualization.

            // Update Game State.

            //throw new NotImplementedException();
        }

        private void TackleBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnMouseDownTackle(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }

        private void ShootBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
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
