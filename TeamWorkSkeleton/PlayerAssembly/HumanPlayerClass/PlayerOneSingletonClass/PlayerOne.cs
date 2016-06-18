namespace PlayerAssembly.HumanPlayerClass.PlayerOneSingletonClass
{
    using HumanPlayerClass;

    public class PlayerOne : HumanPlayer
    {
        private static PlayerOne _player;

        private PlayerOne(string name, string teamName) 
            : base(name, teamName)
        {
        }

        public PlayerOne Player => _player;

        public static void CreatePlayerOne(string name, string teamName)
        {
            PlayerOne._player = new PlayerOne(name, teamName); 
        }
    }
}
