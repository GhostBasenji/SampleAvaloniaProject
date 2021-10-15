using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Demos.SimpleAvaloniaProject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var button = this.FindControl<Button>("CloseWindowButton");

            button.Click += Button_Click;
        }

        private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
