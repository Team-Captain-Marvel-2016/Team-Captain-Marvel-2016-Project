
namespace PlayerAssembly.ComputerPlayerClass.BotPeshoSingletonClass
{
    using ComputerPlayerClass;
    using System.Windows.Media;
    using Teamwork.Models.PC.Computer;

    public class BotPesho : ComputerPlayer
    {
        public BotPesho(string name, string teamName, SolidColorBrush color)
            : base(name, teamName, color)
        {
        }
    }
}
