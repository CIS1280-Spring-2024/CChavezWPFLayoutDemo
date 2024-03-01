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
    /// Interaction logic for DragAndDropDemo.xaml
    /// </summary>
    public partial class DragAndDropDemo : Window
    {
        List<string> ListOne = new List<string>() { "One", "Two", "Three" };
        List<string> ListTwo = new List<string>() { "Four", "Five", "Six" };
        public DragAndDropDemo()
        {
            InitializeComponent();
            lblOne.ItemsSource = ListOne;
            lblTwo.ItemsSource = ListTwo;
        }

        string itemDragged;

        private void lblOne_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // This does not work
            itemDragged = (string)lblOne.SelectedItem;
        }

        private void lblTwo_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
