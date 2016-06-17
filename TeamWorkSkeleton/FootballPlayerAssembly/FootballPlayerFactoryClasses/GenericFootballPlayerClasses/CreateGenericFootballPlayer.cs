namespace FootballPlayerAssembly.FootballPlayerFactoryClasses.GenericFootballPlayerClasses
{
    using FootballPlayerAbstractClass;
    using FootballPlayerSettingsClasses;
    using System;

    /// <summary>
    /// Generate a GenericFootballPlayer
    /// based on the constraints in 
    /// CreationConstants static classes
    /// </summary>
    internal static class CreateGenericFootballPlayer
    {
        private const string Name = "placeholder";

        internal static FootballPlayer CreateGenericAttacker(Random random)
        {
            var pass = random.Next(
                AttackerCreationConstants.Pass.Min,
                AttackerCreationConstants.Pass.Max);

            var shoot = random.Next(
                AttackerCreationConstants.Shoot.Min,
                AttackerCreationConstants.Shoot.Max);

            var dribble = random.Next(
                AttackerCreationConstants.Dribble.Min,
                AttackerCreationConstants.Dribble.Max);

            var save = random.Next(
                AttackerCreationConstants.Save.Min,
                AttackerCreationConstants.Save.Max);

            var tackle = random.Next(
                AttackerCreationConstants.Tackle.Min,
                AttackerCreationConstants.Tackle.Max);

            var intercept = random.Next(
                AttackerCreationConstants.Intercept.Min,
                AttackerCreationConstants.Intercept.Max);

            var awareness = random.Next(
                AttackerCreationConstants.Awareness.Min,
                AttackerCreationConstants.Awareness.Max);

            var ap = random.Next(
                AttackerCreationConstants.Ap.Min,
                AttackerCreationConstants.Ap.Max);

            var newAttacker = new FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return newAttacker;
        }

        internal static FootballPlayer CreateGenericDefender(Random random)
        {
            var pass = random.Next(
                DefenderCreationConstants.Pass.Min,
                DefenderCreationConstants.Pass.Max);

            var shoot = random.Next(
                DefenderCreationConstants.Shoot.Min,
                DefenderCreationConstants.Shoot.Max);

            var dribble = random.Next(
                DefenderCreationConstants.Dribble.Min,
                DefenderCreationConstants.Dribble.Max);

            var save = random.Next(
                DefenderCreationConstants.Save.Min,
                DefenderCreationConstants.Save.Max);

            var tackle = random.Next(
                DefenderCreationConstants.Tackle.Min,
                DefenderCreationConstants.Tackle.Max);

            var intercept = random.Next(
                DefenderCreationConstants.Intercept.Min,
                DefenderCreationConstants.Intercept.Max);

            var awareness = random.Next(
                DefenderCreationConstants.Awareness.Min,
                DefenderCreationConstants.Awareness.Max);

            var ap = random.Next(
                DefenderCreationConstants.Ap.Min,
                DefenderCreationConstants.Ap.Max);

            var newDefender = new FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return newDefender;
        }

        internal static FootballPlayer CreateGenericMidfielder(Random random)
        {
            var pass = random.Next(
               MidfielderCreationConstants.Pass.Min,
               MidfielderCreationConstants.Pass.Max);

            var shoot = random.Next(
                MidfielderCreationConstants.Shoot.Min,
                MidfielderCreationConstants.Shoot.Max);

            var dribble = random.Next(
                MidfielderCreationConstants.Dribble.Min,
                MidfielderCreationConstants.Dribble.Max);

            var save = random.Next(
                MidfielderCreationConstants.Save.Min,
                MidfielderCreationConstants.Save.Max);

            var tackle = random.Next(
                MidfielderCreationConstants.Tackle.Min,
                MidfielderCreationConstants.Tackle.Max);

            var intercept = random.Next(
                MidfielderCreationConstants.Intercept.Min,
                MidfielderCreationConstants.Intercept.Max);

            var awareness = random.Next(
                MidfielderCreationConstants.Awareness.Min,
                MidfielderCreationConstants.Awareness.Max);

            var ap = random.Next(
                MidfielderCreationConstants.Ap.Min,
                MidfielderCreationConstants.Ap.Max);

            var newMidfielder = new FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return newMidfielder;
        }

        internal static FootballPlayer CreateGenericGoalkeeper(Random random)
        {
            var pass = random.Next(
               GoalkeeperCreationConstants.Pass.Min,
               GoalkeeperCreationConstants.Pass.Max);

            var shoot = random.Next(
                GoalkeeperCreationConstants.Shoot.Min,
                GoalkeeperCreationConstants.Shoot.Max);

            var dribble = random.Next(
                GoalkeeperCreationConstants.Dribble.Min,
                GoalkeeperCreationConstants.Dribble.Max);

            var save = random.Next(
                GoalkeeperCreationConstants.Save.Min,
                GoalkeeperCreationConstants.Save.Max);

            var tackle = random.Next(
                GoalkeeperCreationConstants.Tackle.Min,
                GoalkeeperCreationConstants.Tackle.Max);

            var intercept = random.Next(
                GoalkeeperCreationConstants.Intercept.Min,
                GoalkeeperCreationConstants.Intercept.Max);

            var awareness = random.Next(
                GoalkeeperCreationConstants.Awareness.Min,
                GoalkeeperCreationConstants.Awareness.Max);

            var ap = random.Next(
                GoalkeeperCreationConstants.Ap.Min,
                GoalkeeperCreationConstants.Ap.Max);

            var newGoalkeeper = new FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return newGoalkeeper;
        }
    }
}
