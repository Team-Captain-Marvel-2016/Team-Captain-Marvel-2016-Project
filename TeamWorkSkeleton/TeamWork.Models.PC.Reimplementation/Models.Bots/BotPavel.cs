namespace TeamWork.Models.PC.Reimplementation.Models.Bots
{
    using Contracts;

    public class BotPavel : PlayerCharacter, IBot
    {
        public BotPavel(string name) 
            : base("BotPavel")
        {
        }

        public void DecisionLogic()
        {
            throw new System.NotImplementedException();
        }
    }
}