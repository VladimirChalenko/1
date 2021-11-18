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
using System.Windows.Shapes;

namespace WpfApp2.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewServise.xaml
    /// </summary>
    public partial class WindowNewServise : Window
    {
        public WindowNewServise()
        {
            InitializeComponent();
        }
        //кнопка сохранить

        private void Personsave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
