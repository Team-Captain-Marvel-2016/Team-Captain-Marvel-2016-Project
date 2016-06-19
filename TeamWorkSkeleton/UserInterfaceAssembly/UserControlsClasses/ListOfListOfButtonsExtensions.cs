namespace UserInterfaceAssembly.UserControlsClasses
{
    using System.Collections.Generic;
    using System.Windows.Controls;
    
    public static class ListOfListOfButtonsExtensions
    {
        public static void CollapseAll(this List<List<Button>> lists)
        {
            foreach (var list in lists)
            {
                list.CollapseButtons();
            }
        }

        public static void DisplayAll(this List<List<Button>> lists)
        {
            foreach (var list in lists)
            {
                list.DisplayButtons();
            }
        }
    }
}
