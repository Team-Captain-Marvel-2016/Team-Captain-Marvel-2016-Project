namespace StartUpWPF
{
    using Game.PlayingField.Methods;
    using Game.Tracker;
    using Global.Contracts;
    using Global.Settings.Visualization;
    using System;
    using System.Collections.Generic;
    using System.Windows;

    public partial class MainWindow : Window
    {
        private void MoveUpBtn_OnClick(object sender, RoutedEventArgs e)
        {
            this.Move(GameStateTracker.SelectedFootballPlayer.MoveUp);
        }

        private void MoveDownBtn_OnClick(object sender, RoutedEventArgs e)
        {
            this.Move(GameStateTracker.SelectedFootballPlayer.MoveDown);
        }

        private void MoveLeftBtn_OnClick(object sender, RoutedEventArgs e)
        {
            this.Move(GameStateTracker.SelectedFootballPlayer.MoveLeft);
        }

        private void MoveRightBtn_OnClick(object sender, RoutedEventArgs e)
        {
            this.Move(GameStateTracker.SelectedFootballPlayer.MoveRight);
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
            this.GameGraphics.SetGridPosition(new List<IDrawOnCanvas>()
                {
                    GameStateTracker.SelectedFootballPlayer
                },
                PlayingFieldSettings.GridCoordinates);

            this.GameGraphics.SetPosition(
                new List<IDrawOnCanvas>()
                {
                    GameStateTracker.SelectedFootballPlayer
                });

            this.DisplayUI();
        }
    }
}
