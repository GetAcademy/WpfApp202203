using System.Windows;
using System.Windows.Controls;

namespace WpfApp202203
{
    internal class Clicker
    {
        private int _count = 0;
        private Label _label;
        public StackPanel Panel { get; }

        public Clicker()
        {
            var button = new Button();
            button.Content = "Trykk her!";
            button.Click += ButtonClick;

            _label = new Label();

            Panel = new StackPanel();
            Panel.Orientation = Orientation.Horizontal;
            Panel.Children.Add(button);
            Panel.Children.Add(_label);
        }


        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
