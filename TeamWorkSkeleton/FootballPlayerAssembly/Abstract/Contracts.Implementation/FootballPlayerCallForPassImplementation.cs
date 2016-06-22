namespace TeamWork.Models.Abstract
{
    using System;
    using Global.Contracts.Actions;
    using Global.Contracts.Statistics;

    public abstract partial class FootballPlayer : ICallForPass
    {
        public bool CallForPass(IDefenseStats enemey)
        {
            throw new NotImplementedException();
        }
    }
}
