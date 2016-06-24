namespace Game.Logic
{
    using System.Windows.Controls;
    using Global.Enumerations.Team;
    using Global.Settings.Visualization;
    using PlayingField.Methods;
    using TeamWork.Football.Visualizer.Contracts;
    using TeamWork.Models.PC.Reimplementation.Models;
    using Tracker;
    using VisualizationAssembly.CanvasUtilsClasses;
    using VisualizationAssembly.InitPlayingFieldClasses;

    public static class InitialGameState
    {
        public static void InitializePlayers()
        {
            PlayerOne.Initialize(new HumanPlayer("PlayerOne"));
            PlayerTwo.Initialize(new HumanPlayer("PlayerTwo"));
        }

        public static void InitializeVisualizer(IVisualizer visualizer)
        {
            visualizer.Add(PlayerOne.Instance.PlayerCharacter.Team.Team);
            visualizer.Add(PlayerTwo.Instance.PlayerCharacter.Team.Team);

            visualizer.SetPosition(PlayerOne.Instance.PlayerCharacter.Team.Team);
            visualizer.SetPosition(PlayerTwo.Instance.PlayerCharacter.Team.Team);
        }

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

            visualizer.MarkCurrentPlayer(
                GameStateTracker.SelectedFootballPlayer,
                FootballPlayerSettings.SelectedVisualTokenSize,
                FootballPlayerSettings.SelectedVisualTokenSize);

            visualizer.MarkPlayerWithBall(
                GameStateTracker.FootballPlayerWithBall,
                FootballPlayerSettings.BallColor);

            PlayingFieldMethods.UpdateAllPlayers(PlayerOne.Instance.PlayerCharacter.Team.Team);
            PlayingFieldMethods.UpdateAllPlayers(PlayerTwo.Instance.PlayerCharacter.Team.Team);
        }

        private static void GetFootballPlayerPositions(PlayerCharacter playerCharacter, StartingFieldType field)
        {
            InitTeamVisualization
                .GetInitialFootballPlayerPositions(playerCharacter.Team, field);
        }

        private static void DisplayFootballPlayersOnCanvas(Canvas canvas, PlayerCharacter playerCharacter)
        {
            foreach (var player in playerCharacter.Team.Team)
            {
                CanvasChildrenUtilities.AddChild(canvas, player);
            }
        }
    }
}
