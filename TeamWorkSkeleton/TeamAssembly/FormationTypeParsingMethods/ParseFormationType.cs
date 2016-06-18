namespace TeamAssembly.FormationTypeParsingMethods
{
    using FormationTypes;
    using System.Text;

    internal static class ParseFormationType
    {
        private const string RemoveMe = "Formation";
        private const int FormationLength = 3;

        /// <summary>
        /// Return the number of players of each position
        /// to be generated.
        /// [0] -> Defenders
        /// [1] -> Midfielders
        /// [2] -> Attackers
        /// </summary>
        /// <param name="formation"></param>
        /// <returns>int[] Value by position</returns>
        internal static int[] GetFormationValues(FormationType formation)
        {
            var output = new int[FormationLength];

            var toStr = ExtractString(formation);
            var toInt = int.Parse(toStr);

            for (var i = FormationLength - 1; i >= 0; i--)
            {
                output[i] = toInt % 10;
                toInt /= 10;
            }

            return output;
        }

        /// <summary>
        /// Generate a string in format:
        /// [Defenders]-[Midfielders]-[Attackers]
        /// </summary>
        /// <param name="formation"></param>
        /// <returns>string</returns>
        internal static string GetFormationString(FormationType formation)
        {
            var output = new StringBuilder();

            var values = GetFormationValues(formation);

            foreach (var val in values)
            {
                output.Append(val);
                output.Append('-');
            }

            return output.ToString().TrimEnd('-');
        }

        private static string ExtractString(FormationType formation)
        {
            return formation.ToString().Replace(RemoveMe, "");
        }
    }
}
