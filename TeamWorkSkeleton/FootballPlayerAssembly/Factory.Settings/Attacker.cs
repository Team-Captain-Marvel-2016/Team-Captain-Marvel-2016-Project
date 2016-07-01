namespace TeamWork.Models.Factory.Settings
{
    using Global.DataStructures;

    internal class AttackerSettings : IFactorySettings
    {
        internal AttackerSettings()
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
