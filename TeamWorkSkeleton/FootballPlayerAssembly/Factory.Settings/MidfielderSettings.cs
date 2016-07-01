namespace TeamWork.Models.Factory.Settings
{
    using Abstract;
    using Global.DataStructures;

    internal class MidfielderSettings : FactorySettings
    {
        internal MidfielderSettings()
        {
            InitializeDefaultValues();   
        }
        
        protected override void InitializeDefaultValues()
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
    }
}
