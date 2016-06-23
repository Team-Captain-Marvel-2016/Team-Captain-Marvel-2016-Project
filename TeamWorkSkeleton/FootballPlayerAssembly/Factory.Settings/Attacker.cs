namespace TeamWork.Models.Factory.Settings
{
    using Global.DataStructures;

    internal static class Attacker
    {
        static Attacker()
        {
            Pass = new MinMaxRange(50, 90);
            Shoot = new MinMaxRange(70, 100);
            Dribble = new MinMaxRange(60, 90);

            Save = new MinMaxRange(0, 10);
            Tackle = new MinMaxRange(0, 50);
            Intercept = new MinMaxRange(20, 60);

            Awareness = new MinMaxRange(2, 4);
            Ap = new MinMaxRange(4, 6);
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
