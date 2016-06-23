namespace TeamWork.Models.Factory.Models.Generic
{
    using Abstract;
    using Global.Randomization;
    using Settings;

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
                Attacker.Pass.Min,
                Attacker.Pass.Max);

            var shoot = GenericRandomization.Random.Next(
                Attacker.Shoot.Min,
                Attacker.Shoot.Max);

            var dribble = GenericRandomization.Random.Next(
                Attacker.Dribble.Min,
                Attacker.Dribble.Max);

            var save = GenericRandomization.Random.Next(
                Attacker.Save.Min,
                Attacker.Save.Max);

            var tackle = GenericRandomization.Random.Next(
                Attacker.Tackle.Min,
                Attacker.Tackle.Max);

            var intercept = GenericRandomization.Random.Next(
                Attacker.Intercept.Min,
                Attacker.Intercept.Max);

            var awareness = GenericRandomization.Random.Next(
                Attacker.Awareness.Min,
                Attacker.Awareness.Max);

            var ap = GenericRandomization.Random.Next(
                Attacker.Ap.Min,
                Attacker.Ap.Max);

            var newAttacker = new FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return newAttacker;
        }

        internal static FootballPlayer CreateGenericDefender()
        {
            var pass = GenericRandomization.Random.Next(
                Defender.Pass.Min,
                Defender.Pass.Max);

            var shoot = GenericRandomization.Random.Next(
                Defender.Shoot.Min,
                Defender.Shoot.Max);

            var dribble = GenericRandomization.Random.Next(
                Defender.Dribble.Min,
                Defender.Dribble.Max);

            var save = GenericRandomization.Random.Next(
                Defender.Save.Min,
                Defender.Save.Max);

            var tackle = GenericRandomization.Random.Next(
                Defender.Tackle.Min,
                Defender.Tackle.Max);

            var intercept = GenericRandomization.Random.Next(
                Defender.Intercept.Min,
                Defender.Intercept.Max);

            var awareness = GenericRandomization.Random.Next(
                Defender.Awareness.Min,
                Defender.Awareness.Max);

            var ap = GenericRandomization.Random.Next(
                Defender.Ap.Min,
                Defender.Ap.Max);

            var newDefender = new FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return newDefender;
        }

        internal static FootballPlayer CreateGenericMidfielder()
        {
            var pass = GenericRandomization.Random.Next(
               Midfielder.Pass.Min,
               Midfielder.Pass.Max);

            var shoot = GenericRandomization.Random.Next(
                Midfielder.Shoot.Min,
                Midfielder.Shoot.Max);

            var dribble = GenericRandomization.Random.Next(
                Midfielder.Dribble.Min,
                Midfielder.Dribble.Max);

            var save = GenericRandomization.Random.Next(
                Midfielder.Save.Min,
                Midfielder.Save.Max);

            var tackle = GenericRandomization.Random.Next(
                Midfielder.Tackle.Min,
                Midfielder.Tackle.Max);

            var intercept = GenericRandomization.Random.Next(
                Midfielder.Intercept.Min,
                Midfielder.Intercept.Max);

            var awareness = GenericRandomization.Random.Next(
                Midfielder.Awareness.Min,
                Midfielder.Awareness.Max);

            var ap = GenericRandomization.Random.Next(
                Midfielder.Ap.Min,
                Midfielder.Ap.Max);

            var newMidfielder = new FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return newMidfielder;
        }

        internal static FootballPlayer CreateGenericGoalkeeper()
        {
            var pass = GenericRandomization.Random.Next(
               Goalkeeper.Pass.Min,
               Goalkeeper.Pass.Max);

            var shoot = GenericRandomization.Random.Next(
                Goalkeeper.Shoot.Min,
                Goalkeeper.Shoot.Max);

            var dribble = GenericRandomization.Random.Next(
                Goalkeeper.Dribble.Min,
                Goalkeeper.Dribble.Max);

            var save = GenericRandomization.Random.Next(
                Goalkeeper.Save.Min,
                Goalkeeper.Save.Max);

            var tackle = GenericRandomization.Random.Next(
                Goalkeeper.Tackle.Min,
                Goalkeeper.Tackle.Max);

            var intercept = GenericRandomization.Random.Next(
                Goalkeeper.Intercept.Min,
                Goalkeeper.Intercept.Max);

            var awareness = GenericRandomization.Random.Next(
                Goalkeeper.Awareness.Min,
                Goalkeeper.Awareness.Max);

            var ap = GenericRandomization.Random.Next(
                Goalkeeper.Ap.Min,
                Goalkeeper.Ap.Max);

            var newGoalkeeper = new FootballPlayerFactory.GenericFootballPlayer(
                Name, pass, shoot, dribble, save, tackle, intercept, awareness, ap);

            return newGoalkeeper;
        }
    }
}
