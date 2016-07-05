namespace TeamWork.Models.Factory.Settings.Abstract
{
    using Global.DataStructures;
    using Global.IO.Models;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    internal abstract class FactorySettings : IFactorySettings
    {
        protected FactorySettings()
        {
        }

        public MinMaxRange Ap { get; protected set; }

        public MinMaxRange Awareness { get; protected set; }

        public MinMaxRange Intercept { get; protected set; }

        public MinMaxRange Tackle { get; protected set; }

        public MinMaxRange Save { get; protected set; }

        public MinMaxRange Dribble { get; protected set; }

        public MinMaxRange Shoot { get; protected set; }

        public MinMaxRange Pass { get; protected set; }

        protected abstract void InitializeDefaultValues();

        protected void InitializeValuesFromFile(FileInfo file)
        {
            var inputSettingsStrings = GetDataFromFile(file);

            var separator = GetSeparator(inputSettingsStrings.First());

            foreach (var setting in inputSettingsStrings)
            {
                var settingAsArray = setting.Split(separator);

                this.GetType()
                    .GetProperty(settingAsArray[0])
                    .SetValue(
                        this,
                        new MinMaxRange(
                            int.Parse(settingAsArray[1]),
                            int.Parse(settingAsArray[2])));
            }
        }

        private IEnumerable<string> GetDataFromFile(FileInfo file)
        {
            var myReader = new MyFileReader(file);

            return myReader.Read();
        }

        private char GetSeparator(string sample)
        {
            return sample
                .FirstOrDefault(x => !char.IsLetterOrDigit(x));
        }
    }
}
