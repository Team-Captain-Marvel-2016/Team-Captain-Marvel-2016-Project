namespace Global.Enumerations.Utils
{
    using System;
    using System.Linq;
    using Factory;

    public static class EnumerationSize
    {
        public static int GetSpeciesTypeSize()
        {
            var enumSize = Enum.GetValues(typeof(SpeciesType))
                .Cast<SpeciesType>().Count();

            return enumSize;
        }

        public static int GetPositionTypeSize()
        {
            var enumSize = Enum.GetValues(typeof(PositionType))
                .Cast<PositionType>()
                .Count();

            return enumSize;
        }
    }
}
