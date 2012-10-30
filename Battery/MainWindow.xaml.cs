using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Threading;

namespace Battery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Thread thread = new Thread(() =>
            {
                int i = 0;
                while (true)
                {
                    i++;
                    if (i > 314)
                    {
                        i = 0;
                    }
                    this.Dispatcher.Invoke(new Action(() =>
                        {
                            this.battery.pthFiller.Width = i;
                        }));
                    Thread.Sleep(100);
                }
            });
            thread.Start();
        }
    }
}
