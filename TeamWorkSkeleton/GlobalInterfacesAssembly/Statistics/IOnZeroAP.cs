namespace Global.Contracts.Statistics
{
    using System;

    public interface IOnZeroActionPoints
    {
        event EventHandler ZeroActionPoints;
    }
}