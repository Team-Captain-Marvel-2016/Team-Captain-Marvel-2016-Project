namespace TeamWork.Models.PC.Reimplementation.Models.Bots
{
    using Contracts;

    public class BotCuki : PlayerCharacter, IBot
    {
        public BotCuki(string name) 
            : base("BotCuki")
        {
        }

        public void DecisionLogic()
        {
            throw new System.NotImplementedException();
        }
    }
}