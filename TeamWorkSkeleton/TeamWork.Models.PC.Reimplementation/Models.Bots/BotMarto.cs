namespace TeamWork.Models.PC.Reimplementation.Models.Bots
{
    using Contracts;
    public class BotMarto : PlayerCharacter, IBot
    {
        public BotMarto(string name) 
            : base("BotMarto")
        {
        }

        public void DecisionLogic()
        {
            throw new System.NotImplementedException();
        }
    }
}