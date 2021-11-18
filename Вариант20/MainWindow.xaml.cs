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
using WpfApp2.View;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Основная форма, Show метод нужен для нажатия на кнопку и отображения новой формы
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WNPClient_Click(object sender, RoutedEventArgs e)
        {
            WindowClient cl = new WindowClient();
            cl.Show();
        }

        private void WNPServise_Click(object sender, RoutedEventArgs e)
        {
            WindowServise sr = new WindowServise();
            sr.Show();
        }

        private void WNPPayment_Click(object sender, RoutedEventArgs e)
        {
            WindowPayment pay = new WindowPayment();
            pay.Show();
        }
    }
}
