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
using System.Windows.Shapes;

namespace CChavezWPFLayoutDemo
{
    /// <summary>
    /// Interaction logic for RunawayButtonDemo.xaml
    /// </summary>
    public partial class RunawayButtonDemo : Window
    {
        public RunawayButtonDemo()
        {
            InitializeComponent();
        }

        private void btnRun_MouseEnter(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, (int)(this.ActualWidth
              - btnRun.ActualWidth));
            int y = random.Next(0, (int)(this.ActualHeight
              - btnRun.ActualHeight));
            Canvas.SetLeft(btnRun, x);
            Canvas.SetTop(btnRun, y);
        }
    }
}
