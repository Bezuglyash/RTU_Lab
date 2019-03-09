using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace TIMER_1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            off str2 = new off();
            str2.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            reload str3 = new reload();
            str3.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            sleep str4 = new sleep();
            str4.Show();
            Close();
        }
    }
}
