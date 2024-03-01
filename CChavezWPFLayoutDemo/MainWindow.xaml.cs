using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CChavezWPFLayoutDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            Window window = new StackPanelDemo();
            window.Show();
        }

        private void btnWrapPannel_Click(object sender, RoutedEventArgs e)
        {
            Window window = new WrapPanelDemo();
            window.Show();
        }

        private void btnCanvasPannel_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CanvasDemo();
            window.Show();
        }

        private void btnDockPannel_Click(object sender, RoutedEventArgs e)
        {
            Window window = new DockPanelDemo();
            window.Show();
        }

        private void btnGridDemo_Click(object sender, RoutedEventArgs e)
        {
            Window window = new GridDemo();
            window.Show();
        }
    }
}