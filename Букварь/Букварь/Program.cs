using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Букварь
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var knigi = new Dictionary<string, string>()
            {
                {"книга1", "Лев Толстой"},
                {"книга2", "Джейн Остин"},
                {"книга3", "Филип Пулман"},
                {"книга4", "Дуглас Адамс"},
                {"книга5", "Джоан Роулинг"},
                {"книга6", "Харпер Ли"},
                {"книга7", "Алан Александр Милн"},
                {"книга8", "Джордж Оруэлл"},
                {"книга9", "Клайв Стэйплз Льюис"},
                {"книга10", "Клайв Стэйплз Льюис"}
            };

            Console.WriteLine("введите ключ");
            var a = Console.ReadLine();
            if (knigi.TryGetValue(a, out string value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("такого нет");
            }

            Console.WriteLine(" ");

            if (knigi.TryGetValue(a, out string value1))
            {
                knigi.Remove(a);
                Console.WriteLine("значение удалено");
                foreach (var zxc in knigi)
                {
                    Console.WriteLine(zxc.Key + " " + zxc.Value);
                }
            }
            else
            {
                Console.WriteLine("такого нет");
            }

            Console.WriteLine(" ");

            knigi.Clear();
            Console.WriteLine("удалено все здеся");
            foreach (var zxc in knigi)
            {
                Console.WriteLine("пусто здесь");
                Console.WriteLine(zxc.Key + " " + zxc.Value);
            }
        }
    }
}
