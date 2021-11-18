using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;

namespace WpfApp2.ViewModel
{
    class ServiseViewModel
    {
        //Коллекция полей класса Servise
        public ObservableCollection<Servise> ListServise { get; set; } = new ObservableCollection<Servise>();
        public ServiseViewModel()
        {
            //Заполение полей Servise
            this.ListServise.Add(new Servise
            {
                ID = 1,
                Name = "Массаж",
                Price = "30Rub",
            });

            this.ListServise.Add(new Servise
            {
                ID = 2,
                Name ="Стирка",
                Price ="50Rub",
            });
        }
        // проверка ID Для избежания ошибок
        public int MaxId()
        {
            int max = 0;
            foreach (var l in this.ListServise)
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
