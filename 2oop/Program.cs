using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _2oop
{
    class Program
    {
        static void Main(string[] args)
        {
            byte? num_sw = null;
            while (num_sw != 0)
            {
                Console.WriteLine("1 - Типы\n2 - Строки\n3 - Массивы\n4 - Кортежи\n5 - Локальные функции\n6 - checked/unchecked\n0 - Выход");
                num_sw = Convert.ToByte(Console.ReadLine());
                switch(num_sw)
                {
                    case 1:
                        func1();
                        Console.Clear();
                        break;
                    case 2:
                        func2();
                        Console.Clear();
                        break;
                    case 3:
                        func3();
                        Console.Clear();
                        break;
                    case 4:
                        func4();
                        Console.Clear();
                        break;
                    case 5:
                        func5();
                        Console.Clear();
                        break;
                    case 6:
                        func6();
                        Console.Clear();
                        break;
                }
            }
        }

        static void func1()
        {
            string str = "Maxim";
            char ch = 'b';
            int nt = 10;
            bool bol = false;
            double dbl = 4.678932;
            Console.WriteLine($"string {str}\nint {nt}\nbool {bol}\ndooble {dbl}\nchar {ch}");

            Console.WriteLine("\nВведите число: ");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("convert {0}", x);

            byte a = 50;
            short a1;
            int a2;
            long a3;
            a1 = (short)a;//явное преобразование
            a2 = (int)a1;
            a3 = (long)a2;

            byte b = 67;
            short b1;//неявное преобразование
            int b2;
            long b3;
            b1 = b;
            b2 = b1;
            b3 = b2;

            int a11 = 9;
            object x11 = a11;
            int b11 = (int)x;

            byte s = 14;
            var b22 = 0.1;
            var res = b22 + s;
            Console.WriteLine("Неявная типизация {0}", res);

            int? a33 = 8;
            int? b33 = null;
            if (a33 != null)
                Console.WriteLine("a is not null");
            else
                Console.WriteLine("a is null");
            if (b33 != null)
                Console.WriteLine("b is not null");
            else
                Console.WriteLine("b is null");

            var c44 = 1089;
            int b44 = c44;
            Console.Write(b44);
            Console.ReadKey();
        }

        static void func2()//a
        {
            string s;
            string s_1;
            Console.WriteLine("Введите 1 строку: ");
            s = Console.ReadLine();
            Console.WriteLine("Введите 2 строку: ");
            s_1 = Console.ReadLine();
            if (String.Compare(s_1, s) == 0)
                Console.WriteLine("Cтроки равны");
            else
                Console.WriteLine("Строки не равны");
            
            string s1 = "first line";
            string s2 = "second line";
            string s3 = "third line";
            string s21 = "second line ";
            string text = "first line second line third line";

            Console.WriteLine("сцепление 3 строк " + (s1 + s2 + s3));

            Console.WriteLine(s1.Substring(10));
            Console.WriteLine(s2.Substring(0, s2.Length - 2));
            Console.WriteLine(s3.Substring(1, s3.Length - 3) + "\n");

            string[] words = text.Split(' ');
            foreach (string i in words)
            {
                Console.WriteLine($"{i} ");
            }

            Console.WriteLine("\nВставка " + (s1.Insert(6, s21)));

            int ind = s1.Length - 1;
            s1 = s1.Remove(ind);
            Console.WriteLine("\n" + s1);

            var inter = new
            {
                name = "Leo Messi",
                age = 33
            };
            Console.WriteLine($"\n{inter.name} is {inter.age} years old\n");

            //c

            string nul1 = null;
            string nul2 = "";
            string nul3 = "hell";
            Console.WriteLine("String.IsNullOrEmpty" + String.IsNullOrEmpty(nul1));
            Console.WriteLine(String.IsNullOrEmpty(nul2));
            Console.WriteLine(String.IsNullOrEmpty(nul3));

            StringBuilder str1 = new StringBuilder("qwerty");
            Console.WriteLine("\n" + str1);
            Console.WriteLine($"Длина {str1.Length}");
            Console.WriteLine($"Ёмкость {str1.Capacity}\n");

            //////////////////////////////////////////////////

            StringBuilder sb = new StringBuilder("hello ");
            Console.WriteLine($"Длина строки: {sb.Length}"); // 10
            Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 16

            sb.Append(" world");
            Console.WriteLine($"Длина строки: {sb.Length}"); // 22
            Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 32

            sb.Append("!!!");
            Console.WriteLine($"Длина строки: {sb.Length}"); // 28
            Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 32
            Console.WriteLine(sb);

            StringBuilder sb1 = new StringBuilder("C#  language");
            sb1.Insert(3, "programming");
            Console.WriteLine(sb1);

            StringBuilder sb2 = new StringBuilder("C# programming language");
            sb2.Remove(3, 12);
            Console.WriteLine(sb2);

            StringBuilder sb3 = new StringBuilder("C# programming language");
            sb3.Replace("programming", "программа");
            Console.WriteLine(sb3);

            Console.ReadKey();
        }

        //3 задание

        static void func3()
        {
            //a

            int[,] mas = { { 1, 2, 3, 4, 5 }, { 9, 8, 7, 6, 5 } };

            foreach (byte i in mas)
                Console.Write(i + " ");

            Console.Write("\n");

            for (byte i = 0; i < 2; i++)
            {
                for (byte t = 0; t < 5; t++)
                    Console.Write(mas[i, t] + " ");
                Console.WriteLine();
            }

            //b

            string[] mas1 = { "massiv", "ne masssiv", "super masssiv", "super ne massiv" };

            foreach (string i in mas1)
                Console.Write(i + " / ");
            Console.WriteLine("\nДлина массива: " + mas1.Length);

            byte x = 0;
            do
            {
                Console.Write("Какую часть массива заменить: ");
                x = Convert.ToByte(Console.ReadLine());
            } while (x > 5 || x < 0);
            x--;
            mas1[x] = Console.ReadLine();
            foreach (string i in mas1)
                Console.Write(i + " / ");

            Console.Write("\n");

            int[][] mas2 = new int[3][];
            mas2[0] = new int[2];
            mas2[1] = new int[3];
            mas2[2] = new int[4];
            for (int i = 0; i < mas2.Length; i++)
            {
                for (int t = 0; t < mas2[i].Length; t++)
                {
                    Console.WriteLine($"Введите {t + 1} элемент {i + 1} массива: ");
                    mas2[i][t] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < mas2.Length; i++)
            {
                for (int t = 0; t < mas2[i].Length; t++)
                {
                    Console.Write(mas2[i][t] + " ");
                }
                Console.Write("\n");
            }

            var varmas = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < varmas.Length; i++)
                Console.Write(varmas[i]);

            Console.ReadKey();
        }

        //4задание

        static void func4()
        {
            (int, string, char, string, int) tuple = (5, "tuple", 'a', "netuple", 567);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item5);

            var ts = ("строка", 6);
            (string str, int num) = ts;
            Console.WriteLine($"Эта {str} состоит из {num} слов.");

            var tuple1 = (5, 7, 8, 10);
            var tuple2 = (5, 7, 8, 10);
            Console.WriteLine(tuple1 == tuple2);
            Console.WriteLine(tuple1 != tuple2);

            Console.ReadKey();
        }

        //5 задание

        static void func5()
        {
            int[] mas = { 1, 3, 8, 4, 3, 8, 2, 9, 3 };
            Console.Write("Введите строку ");
            string s = Console.ReadLine();
            var corteg = func(mas, s);
            Console.WriteLine($"Максимальный элемент: {corteg.max}");
            Console.WriteLine($"Минимальный элемент: {corteg.min}");
            Console.WriteLine($"Сумма всех элементов: {corteg.sum}");
            Console.WriteLine($"Первая буква слова: {corteg.fw}");

            Console.ReadKey();
        }
        public static (int min, int max, int sum, string fw) func(int[] mas, string s)
        {
            var res = (min: mas[0], max: mas[0], sum: 0, fw: "");
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < res.min)
                    res.min = mas[i];
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > res.max)
                    res.max = mas[i];
            }
            for (int i = 0; i < mas.Length; i++)
                res.sum += mas[i];
            res.fw = s.Remove(1);
            return res;
        }

        static void func6()
        {
            //int a = 2147483647;
            Console.WriteLine(func2());
            //int func1()
            //{
            //    int a = 2147483647;
            //    checked
            //    {
            //        a += 10;
            //    }
            //    return a;
            //}
            int func2()
            {
                int b = 2147483647;
                unchecked
                {
                    b += 10;
                }
                return b;
            }

            Console.ReadKey();
        }
    }
}
