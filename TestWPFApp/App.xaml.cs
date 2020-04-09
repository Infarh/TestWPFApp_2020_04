using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TestWPFApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //MessageBox.Show("Приложение запущено");
        }

        private void Application_Exit(object Sender, ExitEventArgs E)
        {
            //MessageBox.Show("Приложение выгружается...");
        }
    }
}
