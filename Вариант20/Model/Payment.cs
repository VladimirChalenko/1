using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ViewModel;

namespace WpfApp2.Model
{
    //Класс, содержит поля необходимые по заданию

    class Payment
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int ServiceID { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string Amount { get; set; }

        public Payment() { }
        //Конструктор чтобы воспользоваться полями

        public Payment(int id, int clientID, int service, DateTime date, int quantity, string amount)
        {
            this.ID = id;
            this.ClientID = clientID;
            this.ServiceID = service;
            this.Date = date;
            this.Quantity = quantity;
            this.Amount = amount;
        }
        //нужно для правильного вывода полей, в которых содержится ID другого класса(в данном случае таких 2: Client и Servise)
        public Payment CopyFromCompanyDPO(PaymentDPO pay)
        {
            ClientViewModel client = new ClientViewModel();
            int clientid = 0;
            foreach (var cl in client.ListClient)
            {
                if (cl.LastName == pay.ClientID)
                {
                    clientid = cl.ID;
                    break;
                }
            }

            ServiseViewModel servise = new ServiseViewModel();
            int serviseid = 0;
            foreach (var srv in servise.ListServise)
            {
                if (srv.Name == pay.ServiceID)
                {
                    serviseid = srv.ID;
                    break;
                }
            }

            if ((clientid != 0) && (serviseid != 0))
            {
                this.ID = pay.ID;
                this.ClientID = clientid;
                this.ServiceID = serviseid;
                this.Date = pay.Date;
                this.Quantity = pay.Quantity;
                this.Amount = pay.Amount;
            }
            return this;
        }
    }
}
