namespace TeamWork.Models.Factory.Models.Generic
{
    using FootballPlayerAssembly.FootballPlayerSettingsClasses;
    using RandomizersAssembly.StaticRandomizersClasses;
    using FootballPlayer = Abstract.FootballPlayer;

    /// <summary>
    /// Generate a GenericFootballPlayer
    /// based on the constraints in 
    /// CreationConstants static classes
    /// </summary>
    internal static class CreateGenericFootballPlayer
    {
        private const string Name = "placeholder";

        internal static FootballPlayer CreateGenericAttacker()
        {
            var pass = GenericRandomization.Random.Next(
                AttackerCreationConstants.Pass.Min,
                AttackerCreationConstants.Pass.Max);

            var shoot = GenericRandomization.Random.Next(
                AttackerCreationConstants.Shoot.Min,
                AttackerCreationConstants.Shoot.Max);

            var dribble = GenericRandomization.Random.Next(
                AttackerCreationConstants.Dribble.Min,
                AttackerCreationConstants.Dribble.Max);

            var save = GenericRandomization.Random.Next(
                AttackerCreationConstants.Save.Min,
                AttackerCreationConstants.Save.Max);

            var tackle = GenericRandomization.Random.Next(
                AttackerCreationConstants.Tackle.Min,
                AttackerCreationConstants.Tackle.Max);

            var intercept = GenericRandomization.Random.Next(
                AttackerCreationConstants.Intercept.Min,
                AttackerCreationConstants.Intercept.Max);

            var awareness = GenericRandomization.Random.Next(
                AttackerCreationConstants.Awareness.Min,
                AttackerCreationConstants.Awareness.Max);

            var ap = GenericRandomization.Random.Next(
                AttackerCreationConstants.Ap.Min,
                AttackerCreationConstants.Ap.Max);

            var newAttacker = new FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return newAttacker;
        }

        internal static FootballPlayer CreateGenericDefender()
        {
            var pass = GenericRandomization.Random.Next(
                DefenderCreationConstants.Pass.Min,
                DefenderCreationConstants.Pass.Max);

            var shoot = GenericRandomization.Random.Next(
                DefenderCreationConstants.Shoot.Min,
                DefenderCreationConstants.Shoot.Max);

            var dribble = GenericRandomization.Random.Next(
                DefenderCreationConstants.Dribble.Min,
                DefenderCreationConstants.Dribble.Max);

            var save = GenericRandomization.Random.Next(
                DefenderCreationConstants.Save.Min,
                DefenderCreationConstants.Save.Max);

            var tackle = GenericRandomization.Random.Next(
                DefenderCreationConstants.Tackle.Min,
                DefenderCreationConstants.Tackle.Max);

            var intercept = GenericRandomization.Random.Next(
                DefenderCreationConstants.Intercept.Min,
                DefenderCreationConstants.Intercept.Max);

            var awareness = GenericRandomization.Random.Next(
                DefenderCreationConstants.Awareness.Min,
                DefenderCreationConstants.Awareness.Max);

            var ap = GenericRandomization.Random.Next(
                DefenderCreationConstants.Ap.Min,
                DefenderCreationConstants.Ap.Max);

            var newDefender = new FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return newDefender;
        }

        internal static FootballPlayer CreateGenericMidfielder()
        {
            var pass = GenericRandomization.Random.Next(
               MidfielderCreationConstants.Pass.Min,
               MidfielderCreationConstants.Pass.Max);

            var shoot = GenericRandomization.Random.Next(
                MidfielderCreationConstants.Shoot.Min,
                MidfielderCreationConstants.Shoot.Max);

            var dribble = GenericRandomization.Random.Next(
                MidfielderCreationConstants.Dribble.Min,
                MidfielderCreationConstants.Dribble.Max);

            var save = GenericRandomization.Random.Next(
                MidfielderCreationConstants.Save.Min,
                MidfielderCreationConstants.Save.Max);

            var tackle = GenericRandomization.Random.Next(
                MidfielderCreationConstants.Tackle.Min,
                MidfielderCreationConstants.Tackle.Max);

            var intercept = GenericRandomization.Random.Next(
                MidfielderCreationConstants.Intercept.Min,
                MidfielderCreationConstants.Intercept.Max);

            var awareness = GenericRandomization.Random.Next(
                MidfielderCreationConstants.Awareness.Min,
                MidfielderCreationConstants.Awareness.Max);

            var ap = GenericRandomization.Random.Next(
                MidfielderCreationConstants.Ap.Min,
                MidfielderCreationConstants.Ap.Max);

            var newMidfielder = new FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return newMidfielder;
        }

        internal static FootballPlayer CreateGenericGoalkeeper()
        {
            var pass = GenericRandomization.Random.Next(
               GoalkeeperCreationConstants.Pass.Min,
               GoalkeeperCreationConstants.Pass.Max);

            var shoot = GenericRandomization.Random.Next(
                GoalkeeperCreationConstants.Shoot.Min,
                GoalkeeperCreationConstants.Shoot.Max);

            var dribble = GenericRandomization.Random.Next(
                GoalkeeperCreationConstants.Dribble.Min,
                GoalkeeperCreationConstants.Dribble.Max);

            var save = GenericRandomization.Random.Next(
                GoalkeeperCreationConstants.Save.Min,
                GoalkeeperCreationConstants.Save.Max);

            var tackle = GenericRandomization.Random.Next(
                GoalkeeperCreationConstants.Tackle.Min,
                GoalkeeperCreationConstants.Tackle.Max);

            var intercept = GenericRandomization.Random.Next(
                GoalkeeperCreationConstants.Intercept.Min,
                GoalkeeperCreationConstants.Intercept.Max);

            var awareness = GenericRandomization.Random.Next(
                GoalkeeperCreationConstants.Awareness.Min,
                GoalkeeperCreationConstants.Awareness.Max);

            var ap = GenericRandomization.Random.Next(
                GoalkeeperCreationConstants.Ap.Min,
                GoalkeeperCreationConstants.Ap.Max);

            var newGoalkeeper = new FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return newGoalkeeper;
        }
    }
}
