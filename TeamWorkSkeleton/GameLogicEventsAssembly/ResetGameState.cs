namespace GameLogicEventsAssembly
{
    using System;

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
