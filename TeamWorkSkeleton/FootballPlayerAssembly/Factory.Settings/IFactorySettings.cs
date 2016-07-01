namespace TeamWork.Models.Factory.Settings
{
    using Global.DataStructures;

    internal interface IFactorySettings
    {
        MinMaxRange Ap { get; }

        MinMaxRange Awareness { get; }

        MinMaxRange Intercept { get; }

        MinMaxRange Tackle { get; }

        MinMaxRange Save { get; }

        MinMaxRange Dribble { get; }

        MinMaxRange Shoot { get; }

        MinMaxRange Pass { get; }
    }
}