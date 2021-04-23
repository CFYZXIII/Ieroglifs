using System;
using System.Collections.Generic;
using System.Text;

namespace Ieroglif
{
    class Ieroglif
    {
        //возможные слоги иероглифа
       public String[] slog;

        //номер в массиве
        public int index;

        public Ieroglif nextieroglif;

     
        public Ieroglif(String[] slog)
        {
            this.slog = slog;
        }

        
        public void variants(String s) 
        {
            for (int i = 0; i < slog.Length; i++) 
            {
                //если есть следующий, то кидаем на вход метода всё что накопили
                if (nextieroglif != null)
                {
                    
                    nextieroglif.variants(s+slog[i]);
                  
                }
                else
                    Console.WriteLine(s+slog[i]);

            }
           
            
        }

        public void GetAllVariants(String s, List<string> strings)
        {
            for (int i = 0; i < slog.Length; i++)
            {
                //если есть следующий, то кидаем на вход метода всё что накопили
                if (nextieroglif != null)
                {

                    nextieroglif.GetAllVariants(s + slog[i], strings);

                }
                else
                {
                    strings.Add(s + slog[i]);
                }

            }


        }


    }

    class IeroglifList 
    {
        private List<Ieroglif> ierogliflList = new List<Ieroglif>();

        public void Add(Ieroglif ieroglif)
        {
            this.ierogliflList.Add(ieroglif);
            int index = ieroglif.index = ierogliflList.IndexOf(ieroglif);

            if (ierogliflList.Count > 1)
            {
                //записываем в предыдущий иероглиф ссылку на текущий иероглиф
                //соответственно у последнего будет null
                ierogliflList[index - 1].nextieroglif = ieroglif;
            }
           
        }

        public Ieroglif Get(int i)
        {
            return this.ierogliflList[i];
        }

        

       
    }
}
