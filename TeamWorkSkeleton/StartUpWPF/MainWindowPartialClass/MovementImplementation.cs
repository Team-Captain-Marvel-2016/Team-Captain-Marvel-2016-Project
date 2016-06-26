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

        /// <summary>
        /// Unmark a player from the PlayingField grid,
        /// perform the action ( football player method )
        /// Mark the new position on the grid. 
        /// In case of an exception ( indeces out of range of the array )
        /// then cannot move.
        /// If the move was successfull - update the position 
        /// of the VisualToken on the canvas.
        /// Last Display the appropriate action buttons depending 
        /// on position and update the Info text.
        /// </summary>
        /// <param name="action"></param>
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

            if (GameStateTracker.SelectedFootballPlayer.CurrentAP > 0)
            {
                this.DisplayUI();
            }

            this.UpdatePlayerText();
        }
    }
}
