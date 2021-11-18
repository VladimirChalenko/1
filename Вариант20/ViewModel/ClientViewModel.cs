using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;

namespace WpfApp2.ViewModel
{
    class ClientViewModel
    {
        // коллекция где хранятся поля класса Client
        public ObservableCollection<Client> ListClient { get; set; } = new ObservableCollection<Client>();
        public ClientViewModel()
        {
            //Заполнение полей Client
            this.ListClient.Add(new Client
            {
                ID = 1,
                Email = "example@mail.ru",
                FirstName = "Roman",
                LastName = "Makarov",
               
                Phone = 84445556677,
                Status ="Онлайн"
            });

            this.ListClient.Add(new Client
            {
                ID = 2,
                Email = "ExampleNumberTwo@mail.ru",
                FirstName = "Denis",
                LastName = "Ivanov",
               
                Phone = 89998887766,
                Status = "Оффлайн"
            });
        }
        //Проверка ID для избежания ошибок
        public int MaxId()
        {
            int max = 0;
            foreach (var l in this.ListClient)
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
