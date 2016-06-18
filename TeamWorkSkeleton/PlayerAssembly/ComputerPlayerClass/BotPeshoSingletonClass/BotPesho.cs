
namespace PlayerAssembly.ComputerPlayerClass.BotPeshoSingletonClass
{
    using ComputerPlayerClass;
    using System.Windows.Media;

    public class BotPesho : ComputerPlayer
    {
        public BotPesho(string name, string teamName, SolidColorBrush color)
            : base(name, teamName, color)
        {
        }
    }
}
