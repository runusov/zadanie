using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace мебелька
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
        List<string[]> list1 = new List<string[]>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list1.Add(new string[] { fio_tb.Text,name_tb.Text,width_tb.Text,height_tb.Text,pred_tb.Text,price_tb.Text });
            mebel.ItemsSource = list1;
        }

        private void GridViewColumn_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void pred_tb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fio_tb.Clear();
            name_tb.Clear();
            width_tb.Clear();
            height_tb.Clear();
            pred_tb.Clear();
            price_tb.Clear();
        }
    }
}
