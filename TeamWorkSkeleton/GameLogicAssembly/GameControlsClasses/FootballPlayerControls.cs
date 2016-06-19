namespace GameLogicAssembly.GameControlsClasses
{
    public static class FootballPlayerControls
    {
        public static int GetButtonGroupToDisplay()
        {
            // 0 -> SelectionButtons;
            // 1 -> MovementButtons;    0 
            // 2 -> BallActionButtons;  1
            // 3 -> NoBallButtons;      2
            // 4 -> DefenseButtons;     3

            if (GameStateTrackers.SelecterFootballPlayer.HasBall)
            {
                return 2;
            }
            else if (GameStateTrackers.PlayerOnTurn.Team.HasBall)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
    }
}
