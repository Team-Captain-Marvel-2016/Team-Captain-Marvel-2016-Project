namespace TeamWork.Models.Factory.Settings
{
    using Global.DataStructures;

    internal class MidfielderSettings : IFactorySettings
    {
        internal MidfielderSettings()
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

        public MinMaxRange Ap { get; private set; }
        public MinMaxRange Awareness { get; private set; }
        public MinMaxRange Intercept { get; private set; }
        public MinMaxRange Tackle { get; private set; }
        public MinMaxRange Save { get; private set; }
        public MinMaxRange Dribble { get; private set; }
        public MinMaxRange Shoot { get; private set; }
        public MinMaxRange Pass { get; private set; }
    }
}
