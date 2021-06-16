using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Program
    {
        //создать локальную ф-цию
        static (int, int, int, char) locfunc()
        {
            int[] ArrOfInt = new int[] { 1, 2, 3, 4, 5 };
            string text = "Хороший день";
            int maxelement = ArrOfInt[0];
            int minelementl = ArrOfInt[0];
            int summ = 0;
            char firstsimbol = text[1];

            for (int i = 0; i < ArrOfInt.Length; i++)
            {
                if (maxelement < ArrOfInt[i])//max element
                {
                    maxelement = ArrOfInt[i];
                }

                if (minelementl > ArrOfInt[i])
                {
                    minelementl = ArrOfInt[i];
                }
                summ = summ + ArrOfInt[i];
            }

            return (maxelement, minelementl, summ, firstsimbol);
        }

        static void Main(string[] args)
        {
            sbyte type1 = 1;
            short type2 = 2;
            int type3 = 3;
            long type4 = 4;
            byte type5 = 5;
            ushort type6 = 6;
            uint type7 = 7;
            ulong type8 = 8;
            char type9 = 'c';
            bool type10 = true;
            float type11 = 11;
            double type12 = 11.1;
            string type13 = "drvtbve";
            object type14 = type3;//boxing
            int unbox = (int)type14;
            //неявное приведение 
            //byte -> short -> int -> ling -> decimal 
            //byte -> short -> int -> double
            //byte -> short -> float -> double
            //char -> int
            Int16 i16 = 3;
            Int32 i32 = i16;
            Int64 i64 = i32;
            Single s1 = i32;
           
            //явное приведение 
            byte b = (byte)i32;
            Int16 s2 = (Int16)s1;
            double doub1 = 33.0;
            decimal dec1 = (decimal)doub1;
            var sl1 = 3;
            int sum = sl1 + type3;

            //Nullable
            int x1 = 4;
            int? x2 = x1;
            Console.WriteLine(x2);

            Nullable<int> z2 = 5;
            Nullable<bool> enabled2 = null;
            Nullable<System.Double> d2 = 3.3;

            //работа со строками 
            string str1 = "hello";
            string str2 = "world";
            int lenthOfFirstString = str1.Length;
            int lenthOfSecondString = str2.Length;
            if (lenthOfFirstString > lenthOfSecondString)
            {
                Console.WriteLine("первая длиннее");
            }
            if (lenthOfFirstString < lenthOfSecondString)
            {
                Console.WriteLine("ворая длиннее");
            }
            if (lenthOfFirstString == lenthOfSecondString)
            {
                Console.WriteLine("равны");
            }


            string firstst = "ggg";
            string secondst = "hhhh";
            string thirdst = "aaaaaaaaaaa";
            //сцепление
                Console.WriteLine(String.Join(", ", str2));/////////////////////////////////////////////
            //копирование
            string copystr = string.Copy(firstst);
            //выделение подстроки
            String str = "Pew-pew";
            Console.WriteLine(str.Substring(0, 4));// -> Pew-

            //разделение строки на слова
            String s = "Иванов Иван Иванович";
            String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //вставки подстроки в заданную позицию,
            string text = "Хороший день";
            string subString = "замечательный ";

            text = text.Insert(8, subString);
            Console.WriteLine(text);
            //удаление заданной подстроки
            string text1 = "Хороший день";
            int ind = text1.Length - 1;
            text1 = text1.Remove(ind);
            Console.WriteLine(text1);
            //пустая строка
            string emptystr = "";
            string nullnam = null;
            nullnam = "foo";


            //StringBuilder
            StringBuilder sb = new StringBuilder("Привет мир");
            sb.Append("!");//доабвляет подстроку в конец объекта StringBuilder
            sb.Insert(7, "компьютерный ");//вставляет подстроку в объект StringBuilder, начиная с определенного индекса
            Console.WriteLine(sb);
            // удаляем 13 символов, начиная с 7-го
            sb.Remove(7, 13);
            Console.WriteLine(sb);

            //массивы 
            // Объявляем двумерный массив
                int[,] myArr = new int[4, 5];

            Random ran = new Random();

            // Инициализируем данный массив
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    myArr[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
            //массив строк 
            //string[] arrOfStr = new string[10];
            //int n;

            //Console.WriteLine("Задайте кол-воэлементов");

            //n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    arrOfStr[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Результирующий массив");

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(arrOfStr[i] + ", ");
            //}

            //Console.ReadKey();
            //поменять местами эл. массива
            Console.WriteLine();
            Console.WriteLine();

            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            string buff = weekDays[1];
            weekDays[1] = weekDays[3];
            weekDays[3] = buff;

            for (int i = 0; i < 7; i++)
            {
                Console.Write(weekDays[i] + ", ");
            }
            Console.WriteLine();


            //кортеж 
            (int, string, char, string, ulong) corteg1 = (el1: 1, el2: "Tom", el3: 'a', el4: "tod", el5: 45);
            Console.WriteLine(corteg1.Item2);
            Console.WriteLine(corteg1.Item5);
            Console.WriteLine($" {corteg1}");

            //вызов локальной ф-ции

            var tuple = locfunc();
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);
        }
        static Tuple<int, string, char> CreateCortage(string name)
        {
            int len = name.Length;
            string s = "My first name is" + name;
            char ch = (char)(name[0]);
            return Tuple.Create<int, string, char>(len, s, ch);
                //Распаковка кортежей
            var (one, two, three) = CreateCortage(name);
        }
        
    }

}
