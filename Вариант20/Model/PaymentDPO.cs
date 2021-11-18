using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ViewModel;

namespace WpfApp2.Model
{
    class PaymentDPO
    {
        // Отличие от Payment только в том чтобы ID в строковом формате(Нужно для правильного отображения на форме)

        public int ID { get; set; }
        public string ClientID { get; set; }
        public string ServiceID { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string Amount { get; set; }

        public PaymentDPO() { }

        public PaymentDPO(int id, string clientID, string serviceID, DateTime date, int quantity, string amount)
        {
            this.ID = id;
            this.ClientID = clientID;
            this.ServiceID = serviceID;
            this.Date = date;
            this.Quantity = quantity;
            this.Amount = amount;
        }

        public PaymentDPO CopyFromPerson(Payment pay)
        {
            PaymentDPO payDPO = new PaymentDPO();

            ClientViewModel client = new ClientViewModel();
            string statusString = string.Empty;
            foreach (var cl in client.ListClient)
            {
                if (cl.ID == pay.ClientID)
                {
                    statusString = cl.FirstName;
                    break;
                }
            }

            ServiseViewModel serv = new ServiseViewModel();
            string serString = string.Empty;
            foreach (var srv in serv.ListServise)
            {
                if (srv.ID == pay.ServiceID)
                {
                    serString = srv.Name;
                    break;
                }
            }



            if ((statusString != string.Empty) && (serString != string.Empty))
            {
                payDPO.ID = pay.ID;
                payDPO.ClientID = statusString;
                payDPO.ServiceID = serString;
                payDPO.Date = pay.Date;
                payDPO.Quantity = pay.Quantity;
                payDPO.Amount = pay.Amount;
                
            }
            return payDPO;
        }
    }
}
