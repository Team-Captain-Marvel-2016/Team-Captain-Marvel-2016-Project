﻿namespace TeamWork.Models.PC.Reimplementation.Models.Bots
{
    using Contracts;

    public class BotEvlogi : PlayerCharacter, IBot
    {
        public BotEvlogi(string name) 
            : base("BotEvlogi")
        {
        }

        public void DecisionLogic()
        {
            throw new System.NotImplementedException();
        }
    }
}