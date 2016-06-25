namespace Global.Randomization
{
    using System;

    /// <summary>
    /// Static Random() for use throught the project.
    /// Random() must always be static.
    /// </summary>
    public static class GenericRandomization
    {
        static GenericRandomization()
        {
             Random = new Random();
        }

        public static Random Random { get; private set; }
    }
}
