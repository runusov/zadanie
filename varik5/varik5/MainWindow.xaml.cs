using System;
using System.Collections.Generic;
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

namespace varik5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox[] x = new[] { price, kg };
            double otvetik = 1;
            foreach (var kek in x)
            {
                double kekushka;
                double.TryParse(kek.Text, out kekushka);
                otvetik *= kekushka;
            }
            otvet.Text = otvetik.ToString();
        }

        private void price_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            price.Clear();
            kg.Clear();
        }

        private void price_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
