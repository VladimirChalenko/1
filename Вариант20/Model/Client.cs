using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    //Класс, содержит поля необходимые по заданию
    class Client
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Status { get; set; }


        public Client() { }
        //Конструктор чтобы воспользоваться полями
        public Client(int id, string firstname, string lastname, string email, long phone, string status)
        {
            this.ID = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Phone = phone;
            this.Status = status;
        }
        //Клон для тестов(сам по себе ничего не делает)

        public Client ShallowCopy()
        {
            return (Client)this.MemberwiseClone();
        }
    }
}
