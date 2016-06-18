namespace PlayerAssembly.ComputerPlayerClass
{
    using AbstractPlayerClass;
    using System.Windows.Media;

    public abstract class ComputerPlayer : PlayerCharacter
    {
        protected ComputerPlayer(string name, string teamName, SolidColorBrush color)
            : base(name, teamName, color)
        {
        }
    }
}
