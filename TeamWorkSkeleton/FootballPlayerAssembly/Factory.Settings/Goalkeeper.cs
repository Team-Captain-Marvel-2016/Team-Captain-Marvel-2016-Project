namespace TeamWork.Models.Factory.Settings
{
    using Global.DataStructures;

    internal static class Goalkeeper
    {
        static Goalkeeper()
        {
            Pass = new MinMaxRange(30, 60);
            Shoot = new MinMaxRange(30, 80);
            Dribble = new MinMaxRange(30, 60);

            Save = new MinMaxRange(70, 100);
            Tackle = new MinMaxRange(40, 70);
            Intercept = new MinMaxRange(0, 40);

            Awareness = new MinMaxRange(4, 6);
            Ap = new MinMaxRange(3, 5);
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
