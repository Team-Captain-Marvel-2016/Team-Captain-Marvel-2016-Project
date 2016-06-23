namespace Global.Contracts.PC
{
    public interface IPlayer
    {
        string Name { get; }

        IPlayerCharacter Player { get; }

        void CreatePlayer(IPlayerCharacter player, string name, string teamName);
    }
}