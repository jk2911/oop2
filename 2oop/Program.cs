using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _2oop
{
    class Program
    {//1 задание

        //static void Main(string[] args)//a
        //{
        //    string str = "Maxim";
        //    int nt = 10;
        //    bool bol = false;
        //    double dbl = 4.678932;
        //    Console.Write($"string {str}\nint {nt}\nbool {bol}\ndooble {dbl}");
        //    Console.Write("\nВведите число: ");
        //    int x = Convert.ToInt16(Console.ReadLine());
        //    Console.Write("convert {0}", x);
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)//b
        //{
        //    byte a = 50;
        //    short a1;
        //    int a2;
        //    long a3;
        //    a1 = (short)a;//явное преобразование
        //    a2 = (int)a1;
        //    a3 = (long)a2;

        //    byte b = 67;
        //    short b1;//неявное преобразование
        //    int b2;
        //    long b3;
        //    b1 = b;
        //    b2 = b1;
        //    b3 = b2;
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)//c
        //{
        //    int a = 9;
        //    object x = a;
        //    int b = (int)x;
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)//d
        //{
        //    byte s = 14;
        //    var b = 0.1;
        //    var res = b + s;
        //    Console.Write("Неявная типизация {0}", res);
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)//e
        //{
        //    int? a = 8;
        //    int? b = null;
        //    if (a != null)
        //        Console.WriteLine("a is not null");
        //    else
        //        Console.WriteLine("a is null");
        //    if (b != null)
        //        Console.WriteLine("b is not null");
        //    else
        //        Console.WriteLine("b is null");
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)//а
        //{
        //    var c = 10;
        //    uint b = 15u;
        //    b = c;
        //    Console.Write(b);
        //    Console.ReadKey();
        //}

        //2 задание

        //static void Main(string[] args)//a
        //{
        //    string s;
        //    string s1;
        //    Console.WriteLine("Введите 1 строку: ");
        //    s = Console.ReadLine();
        //    Console.WriteLine("Введите 2 строку: ");
        //    s1 = Console.ReadLine();
        //    if (String.Compare(s1, s) == 0)
        //        Console.Write("Cтроки равны");
        //    else
        //        Console.Write("Строки не равны");
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)//b
        //{
        //    string s1 = "first line";
        //    string s2 = "second line";
        //    string s3 = "third line";
        //    string s21 = "second line ";
        //    string text = "first line second line third line";

        //    Console.WriteLine("сцепление 3 строк " + (s1 + s2 + s3));

        //    Console.WriteLine(s1.Substring(10));
        //    Console.WriteLine(s2.Substring(0, s2.Length - 2));
        //    Console.WriteLine(s3.Substring(1, s3.Length - 3) + "\n");

        //    string[] words = text.Split(' ');
        //    foreach (string s in words)
        //    {
        //        Console.WriteLine($"{s} ");
        //    }

        //    Console.WriteLine("\nВставка " + (s1.Insert(6, s21)));

        //    int ind = s1.Length - 1;
        //    s1 = s1.Remove(ind);
        //    Console.WriteLine("\n" + s1);

        //    var inter = new
        //    {
        //        name = "Leo Messi",
        //        age = 33
        //    };
        //    Console.WriteLine($"\n{inter.name} is {inter.age} years old\n");

        //    //c

        //    string nul1 = null;
        //    string nul2 = "";
        //    string nul3 = "hell";
        //    Console.WriteLine(String.IsNullOrEmpty(nul1));
        //    Console.WriteLine(String.IsNullOrEmpty(nul2));
        //    Console.WriteLine(String.IsNullOrEmpty(nul3));

        //    StringBuilder str1 = new StringBuilder("qwerty");
        //    Console.WriteLine("\n" + str1);
        //    Console.WriteLine($"Длина {str1.Length}");
        //    Console.WriteLine($"Ёмкость {str1.Capacity}\n");

        //    //////////////////////////////////////////////////

        //    StringBuilder sb = new StringBuilder("hello ");
        //    Console.WriteLine($"Длина строки: {sb.Length}"); // 10
        //    Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 16

        //    sb.Append(" world");
        //    Console.WriteLine($"Длина строки: {sb.Length}"); // 22
        //    Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 32

        //    sb.Append("!!!");
        //    Console.WriteLine($"Длина строки: {sb.Length}"); // 28
        //    Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 32
        //    Console.WriteLine(sb);

        //    StringBuilder sb1 = new StringBuilder("C#  language");
        //    sb1.Insert(3, "programming");
        //    Console.WriteLine(sb1);

        //    StringBuilder sb2 = new StringBuilder("C# programming language");
        //    sb2.Remove(3, 12);
        //    Console.WriteLine(sb2);

        //    StringBuilder sb3 = new StringBuilder("C# programming language");
        //    sb3.Replace("programming", "программа");
        //    Console.WriteLine(sb3);

        //    Console.ReadKey();
        //}

        //3 задание

        //static void Main(string[] args)//a
        //{
        //    //a

        //    int[,] mas = { { 1, 2, 3, 4, 5 }, { 9, 8, 7, 6, 5 } };

        //    foreach (byte i in mas)
        //        Console.Write(i + " ");

        //    Console.Write("\n");

        //    for (byte i = 0; i < 2; i++)
        //    {
        //        for (byte t = 0; t < 5; t++)
        //            Console.Write(mas[i, t] + " ");
        //        Console.WriteLine();
        //    }

        //    //b

        //    string[] mas1 = { "massiv", "ne masssiv", "super masssiv", "super ne massiv" };

        //    foreach (string i in mas1)
        //        Console.Write(i + " / ");
        //    Console.WriteLine("\nДлина массива: " + mas1.Length);

        //    byte x = 0;
        //    do
        //    {
        //        Console.Write("Какую часть массива заменить: ");
        //        x = Convert.ToByte(Console.ReadLine());
        //    } while (x > 5 || x < 0);
        //    x--;
        //    mas1[x] = Console.ReadLine();
        //    foreach (string i in mas1)
        //        Console.Write(i + " / ");

        //    Console.Write("\n");

        //    int[][] mas2 = new int[3][];
        //    mas2[0] = new int[2];
        //    mas2[1] = new int[3];
        //    mas2[2] = new int[4];
        //    for (int i = 0; i < mas2.Length; i++)
        //    {
        //        for (int t = 0; t < mas2[i].Length; t++)
        //        {
        //            Console.WriteLine($"Введите {t + 1} элемент {i + 1} массива: ");
        //            mas2[i][t] = Convert.ToInt32(Console.ReadLine());
        //        }
        //    }
        //    for (int i = 0; i < mas2.Length; i++)
        //    {
        //        for (int t = 0; t < mas2[i].Length; t++)
        //        {
        //            Console.Write(mas2[i][t] + " ");
        //        }
        //        Console.Write("\n");
        //    }

        //    var varmas = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //    for (int i = 0; i < varmas.Length; i++)
        //        Console.Write(varmas[i]);

        //    Console.ReadKey();
        //}

        //4задание

        static void Main(string[] args)
        {
            var tuple = (5, "tuple", 'a', "netuple", 567);

            Console.ReadKey();
        }
    }
}
