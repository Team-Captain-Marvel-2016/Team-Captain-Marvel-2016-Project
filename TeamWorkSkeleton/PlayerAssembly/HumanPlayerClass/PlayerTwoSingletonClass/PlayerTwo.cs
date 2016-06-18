namespace PlayerAssembly.HumanPlayerClass.PlayerTwoSingletonClass
{
    using HumanPlayerClass;
    using System.Windows.Media;

    public class PlayerTwo : HumanPlayer
    {
        private static PlayerTwo _player;

        private PlayerTwo(string name, string teamName)
            : base(name, teamName, Brushes.Red)
        {
        }

        // ReSharper disable once ConvertToAutoPropertyWithPrivateSetter
        public static PlayerTwo Player => _player;

        public static void CreatePlayerTwo(string name, string teamName)
        {
            if (_player == null)
            {
                _player = new PlayerTwo(name, teamName);
            }
        }
    }
}
