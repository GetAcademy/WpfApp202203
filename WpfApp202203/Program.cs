using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp202203
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var application = new Application();
            var window = new Window();
            var panel = new StackPanel();

            var clicker1 = new ClickerPanel();
            var clicker2 = new ClickerPanel();
            panel.Children.Add(clicker1);
            panel.Children.Add(clicker2);
            //var clicker1 = new Clicker();
            //var clicker2 = new Clicker();
            //panel.Children.Add(clicker1.Panel);
            //panel.Children.Add(clicker2.Panel);
            
            window.Content = panel;
            application.Run(window);
        }

    }
}
