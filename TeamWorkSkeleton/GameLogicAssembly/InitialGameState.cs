namespace Game.Logic
{
    using System.Windows.Controls;
    using Global.Enumerations.Team;
    using PlayingField.Methods;
    using Teamwork.Models.PC.Abstract;
    using Teamwork.Models.PC.Human.Singletons;
    using Tracker;
    using Visualization;

    public static class InitialGameState
    {
        public static void InitializePlayers()
        {
            // Player One
            PlayerOne.CreatePlayerOne("PlayerOne", "Captain Marvel");
            PlayerOne.Player.CreateTeam("Captain Marvel");

            // Player Two
            PlayerTwo.CreatePlayerTwo("PlayerTwo", "Bad Guys");
            PlayerTwo.Player.CreateTeam("Bad Guys");
        }

        public static void InitializeCanvas(Canvas canvas)
        {
            GetFootballPlayerPositions(PlayerOne.Player, StartingFieldType.Left);
            GetFootballPlayerPositions(PlayerTwo.Player, StartingFieldType.Right);

            DisplayFootballPlayersOnCanvas(canvas, PlayerOne.Player);
            DisplayFootballPlayersOnCanvas(canvas, PlayerTwo.Player);
        }

        public static void InitializeFirstTurn(Canvas canvas)
        {
            PlayerOne.Player.Team.Team[5].HasBall = true;
            PlayerOne.Player.Team.HasBallPossession = true;
            PlayerOne.Player.Team.Team[PlayerOne.Player.CurrentPlayer].IsSelected = true;

            CanvasChildrenUtilities.MarkCurrentPlayer(canvas, PlayerOne.Player.Team.Team[5]);
            CanvasChildrenUtilities.MarkPlayerWithBall(canvas, PlayerOne.Player.Team.Team[5]);

            GameStateTracker.PlayerOnTurn = PlayerOne.Player;
            GameStateTracker.SelectedFootballPlayer = PlayerOne.Player.Team.Team[5];
            GameStateTracker.FootballPlayerWithBall = PlayerOne.Player.Team.Team[5];

            PlayingFieldMethods.UpdateAllPlayers();
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
