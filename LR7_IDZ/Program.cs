using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_IDZ
{
    class Programm
    {
        static void Main(string[] args)
        {
            TovarInfo t1 = new TovarInfo("Фрукты", "Персик", 199 );
            TovarInfo t2 = new TovarInfo("Фрукты", "Яблоко", 86);
            TovarInfo t3 = new TovarInfo("Одежда", "Футболка", 600);
            TovarInfo t4 = new TovarInfo("Техника", "Микроволновка", 19999);
            Sklad sk1 = new Sklad("Склад Еды", "Moscow");
            sk1.Add(t1);
            sk1.Add(t2);
            sk1.Delete(t2);
            Sklad sk2 = new Sklad("Склад Одежды", "Moscow");
            sk2.Add(t3);
            Sklad sk3 = new Sklad("Склад Техники", "Stavropol");
            sk3.Add(t4);
            Storage data = new Storage();
            data.Add(sk1);
            data.Add(sk2);
            data.Add(sk3);
            data.Delete(sk2);

            data.Find("Персик");
            data.Find("Носки");
        }
    }
}
