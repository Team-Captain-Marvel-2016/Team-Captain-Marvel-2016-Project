﻿namespace Global.Contracts.Statistics
{
    public interface IDefenseStats
    {
        int StatSave { get; }
        int StatTackle { get; }
        int StatInterception { get; }
    }
}