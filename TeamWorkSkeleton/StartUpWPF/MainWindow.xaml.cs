namespace StartUpWPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;
    using UserInterfaceAssembly.UserControlsClasses;

    /// <summary>
    /// App runs here.
    /// Call Methods elsewhere.
    /// </summary>
    public partial class MainWindow : Window
    {
        internal List<List<Button>> AllButtons;
        internal List<Button> SelectionButtons;
        internal List<Button> MovementButtons;
        internal List<Button> BallActionButtons;
        internal List<Button> NoBallButtons;
        internal List<Button> DefenseButtons;

        public MainWindow()
        {
            InitializeComponent();

            InitializeButtonLists();
            AllButtons.CollapseAll();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            StartBtn.Visibility = Visibility.Collapsed;

            _00_TestingClassesAssembly.WPFCanvasTestingClasses
                .WpfCanvasInitialStateTesting.Test_01(PlayFieldCanvas);
        }

        /// <summary>
        /// Group buttons in groups for ease of access.
        /// </summary>
        private void InitializeButtonLists()
        {
            // Buttons: Prev, Next
            SelectionButtons = new List<Button>();
            SelectionButtons.Add(PrevPlayerBtn);
            SelectionButtons.Add(NextPlayerBtn);

            // Buttons: Up, Down, Left, Right
            MovementButtons = new List<Button>();
            MovementButtons.Add(MoveUpBtn);
            MovementButtons.Add(MoveDownBtn);
            MovementButtons.Add(MoveLeftBtn);
            MovementButtons.Add(MoveRightBtn);

            // Buttons: Pass, Shoot
            BallActionButtons = new List<Button>();
            MovementButtons.Add(PassBtn);
            MovementButtons.Add(ShootBtn);

            // TODO: Create offense without ball button
            // TODO: Create defense tackle button
            // Button: Call For Pass
            NoBallButtons = new List<Button>();

            // Buttons: Tackle
            DefenseButtons = new List<Button>();

            // TODO: Add the remaining two lists
            // All Buttons
            AllButtons = new List<List<Button>>();
            AllButtons.Add(SelectionButtons);
            AllButtons.Add(MovementButtons);
            AllButtons.Add(BallActionButtons);
        }
    }
}
