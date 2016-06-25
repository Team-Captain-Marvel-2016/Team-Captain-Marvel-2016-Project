namespace Game.Events
{
    using System;

    /// <summary>
    /// Reset game to initial state.
    /// Publishes an event, subscribers must have
    /// methods to reset themselves.
    /// </summary>
    public static class ResetGameState
    {
        public static event EventHandler ResetGameEvent;

        public static void Reset()
        {
            OnResetGame();
        }

        private static void OnResetGame()
        {
            var handler = ResetGameEvent;

            handler?.Invoke(null, null);
        }
    }
}
