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
using WpfApp2.Model;
using WpfApp2.ViewModel;

namespace WpfApp2.View
{
    
    public partial class WindowServise : Window
    {
        ServiseViewModel servm = new ServiseViewModel();
        public WindowServise()
        {
            // для корректного вывода на форму
            InitializeComponent();
            WNPServise.ItemsSource = servm.ListServise;
        }
        //кнопка редактировать
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewServise ser = new WindowNewServise
            {
                Title = "Редактирование",
                Owner = this
            };
            Servise srv = WNPServise.SelectedItem as Servise;
            if (srv != null)
            {
                Servise tempsrv = srv.ShallowCopy();
                ser.DataContext = tempsrv;
                if (ser.ShowDialog() == true)
                {
                    srv.Name = tempsrv.Name;
                    srv.Price = tempsrv.Price;
                    

                    WNPServise.ItemsSource = null;
                    WNPServise.ItemsSource = servm.ListServise;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать поле для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        //кнопка удалить
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Servise srv = (Servise)WNPServise.SelectedItem;
            if (srv != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить " + srv.ID +
                srv.Name, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    servm.ListServise.Remove(srv);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать поле для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        //кнопка добавить
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewServise wnServise = new WindowNewServise
            {
                Title = "Новая форма",
                Owner = this
            };
            int maxIdsrv = servm.MaxId() + 1;
            Servise srv = new Servise
            {
                ID = maxIdsrv
            };
            wnServise.DataContext = srv;
            if (wnServise.ShowDialog() == true)
            {
                servm.ListServise.Add(srv);
            }
        }
    }
}
