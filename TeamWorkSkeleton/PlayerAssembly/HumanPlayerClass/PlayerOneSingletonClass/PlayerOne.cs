namespace PlayerAssembly.HumanPlayerClass.PlayerOneSingletonClass
{
    using System;
    using System.Windows.Media;
    using HumanPlayerClass;

    /// <summary>
    /// Encapsulate an Instance behind a private constructor
    /// as a private static field.
    /// 
    /// Only Create a new instace if one does not exist.
    /// ( Singleton )
    /// </summary>
    public class PlayerOne : HumanPlayer
    {
        private static PlayerOne _player;
        
        private PlayerOne(string name, string teamName)
            : base(name, teamName, Brushes.Blue)
        {
        }

        public static PlayerOne Player => _player;

        public static void CreatePlayerOne(string name, string teamName)
        {
            if (_player == null)
            {
                _player = new PlayerOne(name, teamName);
            }
            else
            {
                throw new Exception("Instance already exists");
            }
        }
    }
}
