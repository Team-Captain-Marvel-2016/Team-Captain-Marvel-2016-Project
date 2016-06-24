namespace TeamWork.Models.PC.Reimplementation.Models.Bots
{
    using Contracts;
    public class BotVladi : PlayerCharacter, IBot
    {
        public BotVladi(string name) 
            : base("BotVladi")
        {
        }

        public void DecisionLogic()
        {
            throw new System.NotImplementedException();
        }
    }
}