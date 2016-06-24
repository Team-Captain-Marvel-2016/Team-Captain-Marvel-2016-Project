namespace TeamWork.Models.PC.Reimplementation.Models.Bots
{
    using Contracts;
    public class BotViktor : PlayerCharacter, IBot
    {
        public BotViktor(string name) 
            : base("BotViktor")
        {
        }

        public void DecisionLogic()
        {
            throw new System.NotImplementedException();
        }
    }
}