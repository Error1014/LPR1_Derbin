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
                OtvetTextBlock.Text = "Наибольшая цифра: "+GetMax(n)+"\n"+ "Наименьшая цифра: " + GetMin(n);
            }
        }
        private int GetMax(int[] n)
        {
            int max = n[0];
            for (int i = 0; i < 4; i++)
            {
                if(n[i]>max) max = n[i];
            }
            return max;
        }
        private int GetMin(int[] n)
        {
            int min = n[0];
            for (int i = 0; i < 4; i++)
            {
                if (n[i] < min) min = n[i];
            }
            return min;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dataTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = (TextBox)sender;
            if (!(Char.IsDigit(e.Text, 0) && textBox.Text.Length <4))
            {
                e.Handled = true;
            }
        }
    }
}
