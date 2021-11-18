using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    //Основной класс, для отображения ClientID, ServiseID, создаем необходимые экземпляры
    public partial class WindowPayment : Window
    {

        private PaymentViewModel vmpay;   
        private ClientViewModel vmClient;
        private ServiseViewModel vmServise;


        private ObservableCollection<PaymentDPO> payDPO;

        private List<Client> ClientList;
        private List<Servise> ServiseList;

        public WindowPayment()
        {
            // для корректного вывода на форму
            InitializeComponent();
            vmpay = new PaymentViewModel();
            vmClient = new ClientViewModel();
            vmServise = new ServiseViewModel();


            ClientList = vmClient.ListClient.ToList();
            ServiseList = vmServise.ListServise.ToList();


            payDPO = new ObservableCollection<PaymentDPO>();
            foreach (var i in vmpay.ListPayment)
            {
                PaymentDPO payy = new PaymentDPO();
                payy = payy.CopyFromPerson(i);
                payDPO.Add(payy);
            }
            WNPPayment.ItemsSource = payDPO;
        }
       
       

        //кнопка добавить
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewPayment wnpayment = new WindowNewPayment
            {
                Title = "Новый сотрудник",
                Owner = this
            };
            int maxIdPayment = vmpay.MaxId() + 1;
            PaymentDPO payyDPO = new PaymentDPO
            {
                ID = maxIdPayment
            };
            wnpayment.DataContext = payDPO;
            wnpayment.WNPClient.ItemsSource = ClientList;
            wnpayment.WNPServise.ItemsSource = ServiseList;

            if (wnpayment.ShowDialog() == true)
            {
                Client cl = (Client)wnpayment.WNPClient.SelectedValue;
                Servise sr = (Servise)wnpayment.WNPServise.SelectedValue;


                payyDPO.ClientID = cl.Email;
                payyDPO.ServiceID = sr.Name;

                payDPO.Add(payyDPO);

                Payment payment = new Payment();
                payment = payment.CopyFromCompanyDPO(payyDPO);
                vmpay.ListPayment.Add(payment);
            }
        }

        
        //Кнопка удалить
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            PaymentDPO paayDPO = (PaymentDPO)WNPPayment.SelectedItem;
            if (paayDPO != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные : \n" + "Строка с ID под номером: " + paayDPO.ID,
                "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    payDPO.Remove(paayDPO);
                    Payment pay = new Payment();
                    pay = pay.CopyFromCompanyDPO(paayDPO);
                    vmpay.ListPayment.Remove(pay);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать данные для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    }
}
