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
   // Создаем экземпляр для дальней работы
    public partial class WindowClient : Window
    {
        ClientViewModel client = new ClientViewModel();
        public WindowClient()
        {
            // для правильно вывода на форму полей
            InitializeComponent();
            WNPclient.ItemsSource = client.ListClient;
        }
        // Кнопка добавить
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewClient wnClient = new WindowNewClient
            {
                Title = "Новая форма",
                Owner = this
            };
            int maxIdcl = client.MaxId() + 1;
            Client cl = new Client
            {
                ID = maxIdcl
            };
            wnClient.DataContext = cl;
            if (wnClient.ShowDialog() == true)
            {
                client.ListClient.Add(cl);
            }
        }
        // Кнопка отредактировать
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewClient wnClient = new WindowNewClient
            {
                Title = "Редактирование",
                Owner = this
            };
            Client cl = WNPclient.SelectedItem as Client;
            if (cl != null)
            {
                Client tempcl = cl.ShallowCopy();
                wnClient.DataContext = tempcl;
                if (wnClient.ShowDialog() == true)
                {
                    cl.FirstName = tempcl.FirstName;
                    cl.LastName = tempcl.LastName;
                    cl.Email = tempcl.Email;
                    cl.Phone = tempcl.Phone;
                    cl.Status = tempcl.Status;

                    WNPclient.ItemsSource = null;
                    WNPclient.ItemsSource = client.ListClient;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать поле для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        //Кнопка удалить
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Client cl = (Client)WNPclient.SelectedItem;
            if (cl != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить " + cl.ID +
                cl.FirstName, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    client.ListClient.Remove(cl);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать поле для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
