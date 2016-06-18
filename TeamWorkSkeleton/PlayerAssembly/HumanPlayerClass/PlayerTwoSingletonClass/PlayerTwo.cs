namespace PlayerAssembly.HumanPlayerClass.PlayerTwoSingletonClass
{
    using HumanPlayerClass;

    public class PlayerTwo : HumanPlayer
    {
        private static PlayerTwo _player;

        private PlayerTwo(string name, string teamName)
            : base(name, teamName)
        {
        }

        // ReSharper disable once ConvertToAutoPropertyWithPrivateSetter
        public static PlayerTwo Player => _player;

        public static void CreatePlayerTwo(string name, string teamName)
        {
            PlayerTwo._player = new PlayerTwo(name, teamName);
        }
    }
}
