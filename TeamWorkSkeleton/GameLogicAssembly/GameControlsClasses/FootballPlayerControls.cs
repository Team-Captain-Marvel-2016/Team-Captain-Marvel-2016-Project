namespace GameLogicAssembly.GameControlsClasses
{
    public static class FootballPlayerControls
    {
        /// <summary>
        /// Pick a Button group to display based on current GameState
        /// Player with Ball, Team with Ball        -> Pass, Shoot
        /// Player without Ball, Team with Ball     -> Call for pass
        /// Player without Ball, Team without Ball  -> Tackle
        /// </summary>
        /// <returns> Index of a Button Group to display </returns>
        public static int GetButtonGroupToDisplay()
        {
            // 0 -> SelectionButtons;
            // 1 -> MovementButtons;    
            // 2 -> BallActionButtons;  
            // 3 -> NoBallButtons;      
            // 4 -> DefenseButtons;     
            const int ballActionButtons = 2;
            const int noBallButtons = 3;
            const int defenseButtons = 4;

            if (GameStateTrackers.SelectedFootballPlayer.HasBall)
            {
                return ballActionButtons;
            }
            else if (GameStateTrackers.PlayerOnTurn.Team.HasBall)
            {
                return noBallButtons;
            }
            else
            {
                return defenseButtons;
            }
        }
    }
}
