using System.Windows;
using System.Windows.Controls;

namespace WpfApp202203
{
    internal class ClickerPanel : StackPanel
    {
        private int _count = 0;
        private Label _label;

        public ClickerPanel()
        {
            var button = new Button();
            button.Content = "Trykk her!";
            button.Click += ButtonClick;

            _label = new Label();

            Orientation = Orientation.Horizontal;
            Children.Add(button);
            Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
