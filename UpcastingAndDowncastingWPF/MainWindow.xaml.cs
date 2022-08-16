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

namespace UpcastingAndDowncastingWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var button = (Button)sender;
            //by downcasting we make it possible to access Button class properties
            //button.
            MessageBox.Show("Hello World!");

            //also valid way if you're not sure about runtime type of an object:
            var button = sender as Button;
            if (button != null)
            {
                MessageBox.Show(button.ActualHeight.ToString());
            }
        }
    }
}
