namespace Teamwork.Models.PC.Human.Singletons
{
    using System;
    using System.Windows.Media;
    using Game.Events;

    /// <summary>
    /// Encapsulate an Instance behind a private constructor
    /// as a private static field.
    /// 
    /// Only Create a new instace if one does not exist.
    /// ( Singleton )
    /// </summary>
    public sealed class PlayerTwo : HumanPlayer
    {
        private static PlayerTwo player;

        private PlayerTwo(string name, string teamName)
            : base(name, teamName, Brushes.Red)
        {
            ResetGameState.ResetGameEvent += OnResetGameEvent;
        }
        
        public static PlayerTwo Player => player;

        public static void CreatePlayerTwo(string name, string teamName)
        {
            if (player == null)
            {
                player = new PlayerTwo(name, teamName);
            }
            else
            {
                throw new Exception("Instance already exists");
            }
        }

        // Event handler.
        private static void OnResetGameEvent(object sender, EventArgs args)
        {
            player = null;
        }
    }
}
