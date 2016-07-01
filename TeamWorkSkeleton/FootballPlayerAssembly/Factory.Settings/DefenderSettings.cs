namespace TeamWork.Models.Factory.Settings
{
    using Abstract;
    using Global.DataStructures;

    internal class DefenderSettings : FactorySettings
    {
        internal DefenderSettings()
        {
            InitializeDefaultValues();
        }

        protected override void InitializeDefaultValues()
        {
            Pass = new MinMaxRange(30, 60);
            Shoot = new MinMaxRange(30, 80);
            Dribble = new MinMaxRange(30, 60);

            Save = new MinMaxRange(0, 30);
            Tackle = new MinMaxRange(70, 100);
            Intercept = new MinMaxRange(70, 100);

            Awareness = new MinMaxRange(4, 6);
            Ap = new MinMaxRange(3, 5);
        }
    }
}
