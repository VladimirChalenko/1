using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    class Servise
    {
        //Класс, содержит поля необходимые по заданию

        public int ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public Servise() { }
        //Конструктор чтобы воспользоваться полями

        public Servise(int id, string name, string price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }
        //Клон для тестов(сам по себе ничего не делает)
        public Servise ShallowCopy()
        {
            return (Servise)this.MemberwiseClone();
        }
    }
}
