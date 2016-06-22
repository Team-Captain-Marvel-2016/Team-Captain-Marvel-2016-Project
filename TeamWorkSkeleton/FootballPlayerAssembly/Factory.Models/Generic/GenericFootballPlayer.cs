namespace TeamWork.Models.Factory.Models.Generic
{
    using FootballPlayer = Abstract.FootballPlayer;

    public static partial class FootballPlayerFactory
    {
        /// <summary>
        /// Generic FootballPlayer inheritor,
        /// to simplify moving data down the assembly line 
        /// ( between methods ).
        /// </summary>
        internal class GenericFootballPlayer : FootballPlayer
        {
            internal GenericFootballPlayer(string name) : base(name)
            {
            }

            internal GenericFootballPlayer(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
