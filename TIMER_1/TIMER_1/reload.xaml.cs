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
    /// Логика взаимодействия для reload.xaml
    /// </summary>
    public partial class reload : Window
    {
        DateTime completion_1;
        public reload()
        {
            InitializeComponent();
        }

        struct timing
        {
            public double h;
            public double m;
            public double s;
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timing time;
            if (hours.Text.Length == 0 || minutes.Text.Length == 0 || seconds.Text.Length == 0)
            {
                MessageBox.Show("Каждое поле обязательно для заполнения!");
                reload str3 = new reload();
                str3.Show();
                Close();
                goto start;
            }
            time.h = Convert.ToDouble(hours.Text);
            time.m = Convert.ToDouble(minutes.Text);
            time.s = Convert.ToDouble(seconds.Text);
            completion_1 = DateTime.Now.AddHours(time.h).AddMinutes(time.m).AddSeconds(time.s);
            label_reload.Visibility = Visibility;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        start:
            ;
        }

        private void timerTick(object sender, EventArgs e)
        {
            if (DateTime.Now < completion_1)
            {
                TimeSpan time = completion_1 - DateTime.Now;
                label_reload.Content = "До перезагрузки компьютера осталось " + time.Hours + " часа " + time.Minutes + " минут " + time.Seconds + " секунд!";
                label_reload.Visibility = Visibility.Visible;
            }
            else
            {
                Close();
                Process.Start("shutdown.exe", "/r /t 0");
            }
        }
    }
}
