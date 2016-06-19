
namespace UserInterfaceAssembly.UserControlsClasses
{
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    
    /// <summary>
    /// Provides extensions for List[Button] collections
    /// </summary>
    public static class ListOfButtonsExtensions
    {
        public static void CollapseButtons(this List<Button> buttons)
        {
            foreach (var button in buttons)
            {
                button.Visibility = Visibility.Collapsed;
            }
        }

        public static void DisplayButtons(this List<Button> buttons)
        {
            foreach (var button in buttons)
            {
                button.Visibility = Visibility.Visible;
            }
        }
    }
}
