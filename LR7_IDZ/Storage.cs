using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_IDZ
{
    internal class Storage
    {
        private List<Sklad> data;

        public Storage()
        {
            data = new List<Sklad>();
        }
        public void Add(Sklad sklad)
        {
            data.Add(sklad);
        }
        public void Delete(Sklad sklad)
        {
            if (data.Contains(sklad))
            {
                data.Remove(sklad);
            }
            else
            {
                Console.WriteLine("Склад не найден");
            }
        }
        public void Find(string name)
        {
            bool found = false;
            foreach (Sklad department in data)
            {
                List<TovarInfo> users = department.GetList();
                foreach (TovarInfo user in users)
                {
                    if (name.Equals(user.name))
                    {
                        Console.WriteLine("Товар найден на складе, вывожу информацию");
                        department.GetInfo();
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Товар не найден на складе");
            }
        }
    }
}
