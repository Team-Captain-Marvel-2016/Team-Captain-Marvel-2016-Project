namespace FootballPlayerAssembly.FootballPlayerSettingsClasses
{
    using Global.DataStructures;

    internal static class MidfielderCreationConstants
    {
        static MidfielderCreationConstants()
        {
            Pass = new MinMaxRange(70, 100);
            Shoot = new MinMaxRange(40, 70);
            Dribble = new MinMaxRange(70, 100);

            Save = new MinMaxRange(0, 40);
            Tackle = new MinMaxRange(40, 70);
            Intercept = new MinMaxRange(40, 70);

            Awareness = new MinMaxRange(4, 6);
            Ap = new MinMaxRange(4, 7);
        }

        internal static MinMaxRange Ap { get; private set; }

        internal static MinMaxRange Awareness { get; private set; }

        internal static MinMaxRange Intercept { get; private set; }

        internal static MinMaxRange Tackle { get; private set; }

        internal static MinMaxRange Save { get; private set; }

        internal static MinMaxRange Dribble { get; private set; }

        internal static MinMaxRange Shoot { get; private set; }

        internal static MinMaxRange Pass { get; private set; }
    }
}
