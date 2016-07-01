namespace TeamWork.Models.Factory.Settings
{
    using Abstract;
    using Global.DataStructures;
    using System.IO;

    internal class AttackerSettings : FactorySettings
    {
        private const string FileName = ".\\txt-assets\\attacker-settings.csv";

        internal AttackerSettings()
        {
            try
            {
                InitializeValuesFromFile(new FileInfo(FileName));
            }
            catch (System.Exception)
            {
                InitializeDefaultValues();
            }
        }

        protected override void InitializeDefaultValues()
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
    }
}
