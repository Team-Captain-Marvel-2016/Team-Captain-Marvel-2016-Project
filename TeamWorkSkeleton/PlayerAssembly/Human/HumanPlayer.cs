namespace PlayerAssembly.HumanPlayerClass
{
    using System.Windows.Media;
    using Teamwork.Models.PC.Abstract;

    public abstract class HumanPlayer : PlayerCharacter
    {
        protected HumanPlayer(string name, string teamName, SolidColorBrush color)
            : base(name, teamName, color)
        {
        }
    }
}
