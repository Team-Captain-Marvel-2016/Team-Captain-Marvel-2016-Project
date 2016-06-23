namespace Teamwork.Models.PC.Human
{
    using Abstract;
    using System.Windows.Media;

    public abstract class HumanPlayer : PlayerCharacter
    {
        protected HumanPlayer(string name, string teamName, SolidColorBrush color)
            : base(name, teamName, color)
        {
        }
    }
}
