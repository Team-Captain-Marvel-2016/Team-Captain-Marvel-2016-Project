namespace Game.Logic
{
    using Events;

    /// <summary>
    /// Reset the game state.
    /// </summary>
    public static class ResetGameMethods
    {
        /// <summary>
        /// Invoke the Reset game event.
        /// </summary>
        public static void ResetGame()
        {
            ResetGameState.Reset();
        }
    }
}
