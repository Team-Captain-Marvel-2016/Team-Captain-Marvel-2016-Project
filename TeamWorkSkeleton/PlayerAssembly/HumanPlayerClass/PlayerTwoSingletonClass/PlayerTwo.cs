namespace PlayerAssembly.HumanPlayerClass.PlayerTwoSingletonClass
{
    using HumanPlayerClass;
    using GameLogicEventsAssembly;
    using System;
    using System.Windows.Media;

    /// <summary>
    /// Encapsulate an Instance behind a private constructor
    /// as a private static field.
    /// 
    /// Only Create a new instace if one does not exist.
    /// ( Singleton )
    /// </summary>
    public class PlayerTwo : HumanPlayer
    {
        private static PlayerTwo _player;

        private PlayerTwo(string name, string teamName)
            : base(name, teamName, Brushes.Red)
        {
            ResetGameState.ResetGameEvent += OnResetGameEvent;
        }
        
        public static PlayerTwo Player => _player;

        public static void CreatePlayerTwo(string name, string teamName)
        {
            if (_player == null)
            {
                _player = new PlayerTwo(name, teamName);
            }
            else
            {
                throw new Exception("Instance already exists");
            }
        }

        // Event handler.
        private static void OnResetGameEvent(object sender, EventArgs args)
        {
            _player = null;
        }
    }
}
