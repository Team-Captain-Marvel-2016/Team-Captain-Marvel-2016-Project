namespace TeamWork.Models.PC.Reimplementation.Models.Bots
{
    using Contracts;
    public class BotIvan : PlayerCharacter, IBot
    {
        public BotIvan(string name)
            : base("BotIvan")
        {
        }

        public void DecisionLogic()
        {
            throw new System.NotImplementedException();
        }
    }
}