using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Threading;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.CodeAnalysis;
using System.Reflection;

namespace AspNetCoreHostWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public IWebHost BuildWebHost(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
               .UseUrls(hosturl.Text.Trim())
               .UseHttpSys()
               .UseStartup<WebApplication1.Startup>()
               .Build();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var t = BuildWebHost(null).RunAsync();
            MessageBox.Show("内置ASP.Net Core网站已启动！Enjoy！");
        }
    }
}
