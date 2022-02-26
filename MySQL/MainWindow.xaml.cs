using MahApps.Metro.Controls;
using System.Windows;

namespace MySQL
{  
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {        
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MySQLViewModel (this);
        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }    
}
