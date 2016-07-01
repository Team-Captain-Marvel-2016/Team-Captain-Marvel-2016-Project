﻿namespace TeamWork.Models.Factory.Settings
{
    using Global.DataStructures;

    internal class GoalkeeperSettings : IFactorySettings
    {
        internal GoalkeeperSettings()
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
