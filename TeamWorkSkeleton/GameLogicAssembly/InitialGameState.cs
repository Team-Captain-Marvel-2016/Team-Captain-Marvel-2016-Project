namespace Game.Logic
{
    using Global.Settings.Visualization;
    using PlayingField.Methods;
    using TeamWork.Football.Visualizer.Contracts;
    using TeamWork.Models.PC.Reimplementation.Models;
    using Tracker;

    /// <summary>
    /// Initial Game State.
    /// This is used when Start Game button is clicked.
    /// </summary>
    public static class InitialGameState
    {
        /// <summary>
        /// Create players and their teams
        /// </summary>
        public static void InitializePlayers()
        {
            PlayerOne.Initialize(new HumanPlayer("BotViktor"));
            PlayerTwo.Initialize(new HumanPlayer("BotDoncho"));
        }

        /// <summary>
        /// Add IDrawOnCanvas objects to the visualizer.
        /// Each FootballPlayer objects inherits the interface, 
        /// each FootballPlayer.VisualToken is being added as child of the canvas.
        /// </summary>
        /// <param name="visualizer"></param>
        public static void InitializeVisualizer(IVisualizer visualizer)
        {
            visualizer.Add(PlayerOne.Instance.PlayerCharacter.Team.Team);
            visualizer.Add(PlayerTwo.Instance.PlayerCharacter.Team.Team);

            visualizer.SetPosition(PlayerOne.Instance.PlayerCharacter.Team.Team);
            visualizer.SetPosition(PlayerTwo.Instance.PlayerCharacter.Team.Team);
        }

        /// <summary>
        /// Initializes the first turn state.
        /// Player with ball, team with ball, selected football player.
        /// All GameStateTracker static props are being assigned here, 
        /// preparing the game.
        /// </summary>
        /// <param name="visualizer"></param>
        public static void InitializeFirstTurn(IVisualizer visualizer)
        {
            PlayingFieldMethods.MarkAllPlayersFromTeam(PlayerOne.Instance.PlayerCharacter.Team.Team);
            PlayingFieldMethods.MarkAllPlayersFromTeam(PlayerTwo.Instance.PlayerCharacter.Team.Team);

            PlayerOne.Instance.PlayerCharacter.Team.HasBallPossession = true;

            GameStateTracker.PlayerOnTurn = PlayerOne.Instance;

            GameStateTracker.SelectedFootballPlayer =
                PlayerOne.Instance.PlayerCharacter.Team.Team[
                    PlayerOne.Instance.PlayerCharacter.CurrentPlayer];

            GameStateTracker.FootballPlayerWithBall =
                PlayerOne.Instance.PlayerCharacter.Team.Team[
                    PlayerOne.Instance.PlayerCharacter.CurrentPlayer];

            GameStateTracker.FootballPlayerWithBall.HasBall = true;

            visualizer.SetTokenSize(
                GameStateTracker.SelectedFootballPlayer,
                FootballPlayerSettings.SelectedVisualTokenSize,
                FootballPlayerSettings.SelectedVisualTokenSize);

            visualizer.SetTokenColor(
                GameStateTracker.FootballPlayerWithBall,
                FootballPlayerSettings.BallColor);

            PlayingFieldMethods.UpdateAllPlayers(PlayerOne.Instance.PlayerCharacter.Team.Team);
            PlayingFieldMethods.UpdateAllPlayers(PlayerTwo.Instance.PlayerCharacter.Team.Team);
        }
    }
}
