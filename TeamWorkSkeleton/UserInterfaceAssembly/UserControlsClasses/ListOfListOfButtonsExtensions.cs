namespace UserInterfaceAssembly.UserControlsClasses
{
    using System.Collections.Generic;
    using System.Windows.Controls;
    
    public static class ListOfListOfButtonsExtensions
    {
        /// <summary>
        /// Hide all buttons from view.
        /// </summary>
        /// <param name="lists"></param>
        public static void CollapseAll(this List<List<Button>> lists)
        {
            foreach (var list in lists)
            {
                list.CollapseButtons();
            }
        }

        /// <summary>
        /// Display all buttons on screen.
        /// </summary>
        /// <param name="lists"></param>
        public static void DisplayAll(this List<List<Button>> lists)
        {
            foreach (var list in lists)
            {
                list.DisplayButtons();
            }
        }

        /// <summary>
        /// Disable all buttons.
        /// </summary>
        /// <param name="lists"></param>
        public static void DisableAll(this List<List<Button>> lists)
        {
            foreach (var list in lists)
            {
                list.DisableButtons();
            }
        }

        /// <summary>
        /// Enable all buttons.
        /// </summary>
        /// <param name="lists"></param>
        public static void EnableAll(this List<List<Button>> lists)
        {
            foreach (var list in lists)
            {
                list.EnableButtons();
            }
        }
    }
}
