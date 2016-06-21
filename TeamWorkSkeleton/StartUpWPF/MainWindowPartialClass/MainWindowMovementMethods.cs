namespace StartUpWPF
{
    using GameStateTrackerAssembly;
    using PlayingFieldMethodsAssembly;
    using System;
    using System.Windows;
    using VisualizationAssembly.CanvasUtilsClasses;

    public partial class MainWindow : Window
    {
        private void MoveUpBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Move(GameStateTracker.SelectedFootballPlayer.MoveUp);
        }

        private void MoveDownBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Move(GameStateTracker.SelectedFootballPlayer.MoveDown);
        }

        private void MoveLeftBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Move(GameStateTracker.SelectedFootballPlayer.MoveLeft);
        }

        private void MoveRightBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Move(GameStateTracker.SelectedFootballPlayer.MoveRight);
        }

        private void Move(Action action)
        {
            if (GameStateTracker.SelectedFootballPlayer.ActionPoints <= 0)
            {
                // TODO: Communicate Can't Move
                return;
            }

            // Move Player On the Grid
            try
            {
                PlayingFieldMethods.UnMarkPlayerPosition
                    (GameStateTracker.SelectedFootballPlayer);

                action.Invoke();

                PlayingFieldMethods.MarkPlayerPosition
                    (GameStateTracker.SelectedFootballPlayer);
            }
            catch (Exception)
            {
                // TODO: Communicate Position was not free
                PlayingFieldMethods.MarkPlayerPosition
                    (GameStateTracker.SelectedFootballPlayer);

                return;
            }

            // Update Canvas Position
            CanvasChildrenUtilities
                .UpdateCanvasPosition(this.PlayFieldCanvas, GameStateTracker.SelectedFootballPlayer);
        }
    }
}
