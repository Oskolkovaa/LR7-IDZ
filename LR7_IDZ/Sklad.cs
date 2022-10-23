using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_IDZ
{
    internal class Sklad
    {
        private string name;
        private string location;
        private List<TovarInfo> tovars;

        public Sklad(string pName, string pLocation)
        {
            name = pName;
            location = pLocation;
            tovars = new List<TovarInfo>();
        }
        public void Add(TovarInfo tovar)
        {
            tovars.Add(tovar);
        }
        public void Delete(TovarInfo tovar)   
        {
            if (tovars.Contains(tovar))
            {
                tovars.Remove(tovar);
            }
            else
            {
                Console.WriteLine("Данного товара не существует");
                Console.WriteLine();
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Название склада: {name} \n Город: {location} \n Количество уникальных товаров: {tovars.Count.ToString()}");
            Console.WriteLine();
        }
        public List<TovarInfo> GetList()
        {
            return tovars;
        }
    }
}
