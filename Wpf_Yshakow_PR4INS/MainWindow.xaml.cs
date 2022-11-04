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

namespace Wpf_Yshakow_PR4INS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int a;
        int b;
        int x;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b = Int32.Parse(cheslo1.Text);
            Random r = new Random();
            x = r.Next(b);
        }

    

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(cheslo2.Text);


            if (a == x)
            {
                label1.Content = "Вы угадали";
            }
            else if (a > x)
            {
                label1.Content = "Меньше";
            }
            else
            {
                label1.Content = "Больше";
            }
        }
    }
}
