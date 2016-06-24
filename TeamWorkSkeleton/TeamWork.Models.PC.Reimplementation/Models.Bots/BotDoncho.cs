namespace TeamWork.Models.PC.Reimplementation.Models.Bots
{
    using Contracts;

    public class BotDoncho : PlayerCharacter, IBot
    {
        public BotDoncho(string name) 
            : base("BotDoncho")
        {
        }

        public void DecisionLogic()
        {
            throw new System.NotImplementedException();
        }
    }
}