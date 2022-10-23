using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_IDZ
{
    internal class TovarInfo
    {
        public string category { get; private set; }
        public string name { get; private set; }
        public float price { get; private set; }
        public TovarInfo(string pCategory, string pName, float pPrice)
        {
            category = pCategory;
            name = pName;
            price = pPrice;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Категория: {category} \n Название: {name} \n Цена: {price}");
            Console.WriteLine();
        }
    }
}
