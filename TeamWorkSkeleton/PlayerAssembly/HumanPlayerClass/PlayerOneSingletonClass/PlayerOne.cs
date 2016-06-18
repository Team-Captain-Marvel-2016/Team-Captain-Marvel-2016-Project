namespace PlayerAssembly.HumanPlayerClass.PlayerOneSingletonClass
{
    using System.Windows.Media;
    using HumanPlayerClass;

    public class PlayerOne : HumanPlayer
    {
        private static PlayerOne _player;

        private PlayerOne(string name, string teamName)
            : base(name, teamName, Brushes.Blue)
        {
        }

        public PlayerOne Player => _player;

        public static void CreatePlayerOne(string name, string teamName)
        {
            if (_player == null)
            {
                _player = new PlayerOne(name, teamName);
            }
        }
    }
}
