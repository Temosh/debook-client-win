using System.Windows;
using DebookClientWin.Core.Utils;

namespace DebookClientWin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly RestClient _restClient;

        public MainWindow()
        {
            InitializeComponent();

            _restClient = new RestClient("http://185.25.117.98:8000/debook");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = _restClient.GetLocalDebts();
        }
    }
}
