namespace GameLogicAssembly.GameControlsClasses
{
    public static class FootballPlayerControls
    {
        public static int GetButtonGroupToDisplay()
        {
            // 0 -> SelectionButtons;
            // 1 -> MovementButtons;    
            // 2 -> BallActionButtons;  
            // 3 -> NoBallButtons;      
            // 4 -> DefenseButtons;     

            if (GameStateTrackers.SelectedFootballPlayer.HasBall)
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
