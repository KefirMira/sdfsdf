using System.Windows;
using System.Windows.Media;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private  int i = 0;
        SolidColorBrush[] colors =
        {
            Brushes.Yellow, Brushes.Green, 
            Brushes.Blue
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CliclBTH_OnClick(object sender, RoutedEventArgs e)
        {
            if (i % 2 == 0)
            {
                Background = colors[0];
                CliclBTH.Background = colors[1];
                i++;
            }
            else
            {
                Background = colors[1];
                CliclBTH.Background = colors[0];
                i++;
                
            }
        }
    }
}