using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;

namespace WpfApp2.ViewModel
{
    class PaymentViewModel
    {
        // коллекция где хранятся поля класса Payment

        public ObservableCollection<Payment> ListPayment { get; set; } = new ObservableCollection<Payment>();
        public PaymentViewModel()
        {
            //Заполнение полей Payment

            this.ListPayment.Add(new Payment
            {
                ID = 1,
                ClientID = 1,
                ServiceID = 1,
                Date = new DateTime(2000, 05, 10),
                Quantity = 10,
                Amount = "220Rub"
            });

            this.ListPayment.Add(new Payment
            {
                ID = 2,
                ClientID = 2,
                ServiceID = 2,
                Date = new DateTime(1999, 10, 20),
                Quantity = 500,
                Amount = "3000Rub"
            });
        }
        // Проверка ID для избежания ошибок
        public int MaxId()
        {
            int max = 0;
            foreach (var l in this.ListPayment)
            {
                if (max < l.ID)
                {
                    max = l.ID;
                };
            }
            return max;
        }
    }
}
