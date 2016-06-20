
namespace StartUpWPF
{
    using FootballPlayerAssembly.FootballPlayerAbstractClass;
    using GameStateTrackerAssembly;
    using System;
    using System.Windows;

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
            RemoveMouseDownEventPass();
            
            GameStateTracker.TargetFootballPlayer = (FootballPlayer)sender;
            
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


    }
}
