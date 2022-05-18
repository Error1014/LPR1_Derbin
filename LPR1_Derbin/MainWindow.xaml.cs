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

namespace LPR1_Derbin
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

        private void GetResult(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(dataTextBox.Text);
            if (num>9999)
            {
                MessageBox.Show("Вы ввели большое число");
                return;
            }
            else if (num<1000)
            {
                MessageBox.Show("Вы ввели маленькое число");
                return;
            }
            else
            {
                int[] n = new int[4];
                n[0] = num / 1000;
                n[1] = (num % 1000)/100;
                n[2] = (num % 100)/10;
                n[3] = (num % 10);
                MessageBox.Show(n[0].ToString()+ " "+ n[1].ToString() + " " + n[2].ToString() + " " + n[3].ToString() + " " );
            }
        }
        

        private void Exit(object sender, RoutedEventArgs e)
        {

        }
    }
}
