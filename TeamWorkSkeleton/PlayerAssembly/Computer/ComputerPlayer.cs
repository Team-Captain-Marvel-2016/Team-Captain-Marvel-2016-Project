namespace Teamwork.Models.PC.Computer
{
    using System.Windows.Media;
    using Teamwork.Models.PC.Abstract;

    public abstract class ComputerPlayer : PlayerCharacter
    {
        protected ComputerPlayer(string name, string teamName, SolidColorBrush color)
            : base(name, teamName, color)
        {
        }
    }
}
