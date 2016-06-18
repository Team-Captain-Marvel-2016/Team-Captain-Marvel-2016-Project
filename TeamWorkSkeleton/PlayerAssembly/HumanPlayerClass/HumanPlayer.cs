
namespace PlayerAssembly.HumanPlayerClass
{
    using AbstractPlayerClass;

    public abstract class HumanPlayer : PlayerCharacter
    {
        protected HumanPlayer(string name, string teamName) 
            : base(name, teamName)
        {
        }
    }
}
