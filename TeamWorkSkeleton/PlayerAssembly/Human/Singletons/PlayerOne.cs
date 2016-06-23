namespace Teamwork.Models.PC.Human.Singletons
{
    using Abstract;
    using Game.Events;
    using System;
    using System.Windows.Media;
    
    /// <summary>
    /// Encapsulate an Instance behind a private constructor
    /// as a private static field.
    /// 
    /// Only Create a new instace if one does not exist.
    /// ( Singleton )
    /// </summary>
    public sealed class PlayerOne : HumanPlayer
    {
        private static PlayerCharacter player;
        
        private PlayerOne(string name, string teamName)
            : base(name, teamName, Brushes.Blue)
        {
            ResetGameState.ResetGameEvent += OnResetGameEvent;
        }

        public static PlayerCharacter Player => player;

        public static void CreatePlayerOne(string name, string teamName)
        {
            if (player == null)
            {
                player = new PlayerOne(name, teamName);
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
