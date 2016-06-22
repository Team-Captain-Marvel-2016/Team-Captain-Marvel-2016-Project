namespace GlobalInterfacesAssembly.StatsInterfaces
{
    using System;

    public interface IOnZeroActionPoints
    {
        event EventHandler ZeroActionPoints;
    }
}