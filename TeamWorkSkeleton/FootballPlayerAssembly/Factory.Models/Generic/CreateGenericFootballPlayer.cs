namespace TeamWork.Models.Factory.Models.Generic
{
    using Abstract;
    using Global.Randomization;
    using Settings.Abstract;

    /// <summary>
    /// Generate a GenericFootballPlayer
    /// based on the constraints in 
    /// CreationConstants static classes
    /// </summary>
    internal static class CreateGenericFootballPlayer
    {
        private const string Name = "placeholder";

        internal static FootballPlayer CreateGeneric(IFactorySettings settings)
        {
            var pass = GenericRandomization.Random.Next(
                settings.Pass.Min,
                settings.Pass.Max);

            var shoot = GenericRandomization.Random.Next(
                settings.Shoot.Min,
                settings.Shoot.Max);

            var dribble = GenericRandomization.Random.Next(
                settings.Dribble.Min,
                settings.Dribble.Max);

            var save = GenericRandomization.Random.Next(
                settings.Save.Min,
                settings.Save.Max);

            var tackle = GenericRandomization.Random.Next(
                settings.Tackle.Min,
                settings.Tackle.Max);

            var intercept = GenericRandomization.Random.Next(
                settings.Intercept.Min,
                settings.Intercept.Max);

            var awareness = GenericRandomization.Random.Next(
                settings.Awareness.Min,
                settings.Awareness.Max);

            var ap = GenericRandomization.Random.Next(
                settings.Ap.Min,
                settings.Ap.Max);

            var genericFootballPlayer = new FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return genericFootballPlayer;
        }
    }
}
