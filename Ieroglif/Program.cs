using System;
using System.Collections.Generic;

namespace Ieroglif
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //создаём иероглифы
           Ieroglif a = new Ieroglif(new string[] { "sin", "zin", "pin","loh" });
           Ieroglif b = new Ieroglif(new string[] { "sun", "hun", "kan" });
           Ieroglif c = new Ieroglif(new string[] { "hao", "mao", "lao" });

            //словарь иероглифов
            Dictionary<string, Ieroglif> ieroglifs = new Dictionary<string, Ieroglif>();

            ieroglifs.Add("a", a);
            ieroglifs.Add("b", b);
            ieroglifs.Add("c", c);

            //Список иероглифов которые будут заполняться
            IeroglifList ieroglifList = new IeroglifList();

            //приходит на вход строка...
            String s = "abc";

            
            //идём по строке и ищем наши иероглифы
            for (int i = 0; i < s.Length; i++)
            {
                ieroglifList.Add(ieroglifs[s[i].ToString()]); // считаю всё в string,  если захочешь потом переделаешь в char
            }

            //вывод полученных комбинаций
           

            //список возможных комбинаций
            List<string> strings = new List<string>();
 
            //перебираем комбинации...
            ieroglifList.Get(0).GetAllVariants(string.Empty,strings);

            foreach (string l in strings)
            {
                Console.WriteLine("комбинация "+strings.IndexOf(l)+" из "+strings.Count+" " + l);
            }

            //дальше с полученным списком комбинаций можно делать что угодно
            
        }
    }
}
