using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp202203
{
    internal class Program
    {
        /*
         Pause til 11:06
         */

        private static int _count = 0;
        private static Label _label;

        [STAThread]
        public static void Main(string[] args)
        {
            var application = new Application();
            var window = new Window();

            var button = new Button();
            button.Content = "Trykk her!";
            button.Click += ButtonClick;

            _label = new Label();

            var panel = new StackPanel();
            panel.Children.Add(button);
            panel.Children.Add(_label);

            window.Content = panel;
            application.Run(window);
        }

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
