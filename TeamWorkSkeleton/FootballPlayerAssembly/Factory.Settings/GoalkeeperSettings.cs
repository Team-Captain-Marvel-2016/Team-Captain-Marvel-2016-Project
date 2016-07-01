namespace TeamWork.Models.Factory.Settings
{
    using Abstract;
    using Global.DataStructures;

    internal class GoalkeeperSettings : FactorySettings
    {
        internal GoalkeeperSettings()
        {
            InitializeDefaultValues();
        }
        
        protected override void InitializeDefaultValues()
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
    }
}
