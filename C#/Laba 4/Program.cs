using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Mlist list1 = new Mlist { value = "main list" };
            Mlist list2 = new Mlist { value = "sub list" };
            Mlist item1 = new Mlist { value = "e" };
            Console.WriteLine((list1 + item1).value);
            Console.WriteLine(list1 == list2);
            Console.WriteLine((list1 * list2).value);
            Console.WriteLine((-- list1 ).value);
            //вложенный класс
            Mlist.Date data = new Mlist.Date();
            data.method();
            //методы расширения
            List<int> amounts = new List<int>();
            amounts.Add(10);
            amounts.Add(15);
            amounts.Add(40);
            amounts.Add(6);

            amounts.First();
            ListMhetod.GetSum(amounts, "Your sum is ");
        }
    }

    public class Mlist
    {
        public Mlist() {
            owner owner1 = new owner();


            owner1.name = null;
        }
        public  string value { get; set; }
        public static Mlist operator +(Mlist item, Mlist list)// добавить элемент в начало списка
        {
            return new Mlist
            {
                value =  list.value + item.value
            };
        }

        
        public static bool operator ==(Mlist c1, Mlist c2)//сравнение двух списков
        { if (c1.value == c2.value)
                return true;
           else
                return false;
        }
        public static bool operator !=(Mlist _1list, Mlist _2list)
        {
            if (_1list.value != _2list.value)
                return true;
            else
                return false;
        }

        public static Mlist operator *(Mlist _list1, Mlist _list2)// объединение двух списков 
        {
            return new Mlist
            {
                value = _list1.value + _list2.value

            };
        }

        public static Mlist operator --(Mlist _str)
        {
            return new Mlist
            {
                  value = _str.value.Remove(0,1)
            };

            
        }

        //вложенный класс
        public class Date
        {
            public void method()
            {
                Console.WriteLine("Дата создания");
            }
        }

        //вложенный объект
         class owner
        {
            Mlist id;
           public Mlist name;
            Mlist organization;
        }
        
        
        //owner1.id = null;

         //
         
       
    }
    static class ListMhetod
    {
        static public int GetSum(this List<int> amounts, string message)
        {
            int summ = 0;

            foreach (int amount in amounts)
                summ += amount;

            Console.WriteLine(message + summ.ToString());

            return summ;
        }
    }
}
