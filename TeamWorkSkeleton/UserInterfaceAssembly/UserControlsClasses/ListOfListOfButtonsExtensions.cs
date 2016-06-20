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

        public static void DisableAll(this List<List<Button>> lists)
        {
            foreach (var list in lists)
            {
                list.DisableButtons();
            }
        }

        public static void EnableAll(this List<List<Button>> lists)
        {
            foreach (var list in lists)
            {
                list.EnableButtons();
            }
        }
    }
}
