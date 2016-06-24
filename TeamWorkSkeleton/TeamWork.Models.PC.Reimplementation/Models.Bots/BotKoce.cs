namespace TeamWork.Models.PC.Reimplementation.Models.Bots
{
    using Contracts;

    public class BotKoce : PlayerCharacter, IBot
    {
        public BotKoce(string name) 
            : base("BotKoce")
        {
        }

        public void DecisionLogic()
        {
            throw new System.NotImplementedException();
        }
    }
}