using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromIdiot2Junior3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple function 'summer'");
            int a = 1;
            int b = 2;
            int c = 3;
            Summer(a, b);
            Summer(a, b, c);
            Console.WriteLine();
            Console.WriteLine("Summer2 is a function with pre-defined values in case something is missing");
            int d;
            d = 1;
            Summer2(d);
            Console.WriteLine("Summer2 with 1 argument and position 2");
            Summer2(d, 5);
            Console.WriteLine("Summer2 with 1 argument and position 3");
            Summer2(d,c:10);
            int k = Dodaj(a, b);
            Console.WriteLine(k);
            int zmienna = 10;
            string int2string = Zamieniacz(zmienna);
            Console.WriteLine("hurr durr konkatenacja 10->"+int2string);
            Console.WriteLine("checked the 'ref' and 'out' stuff on simple ints, now tables");
            int[] tab = new int[3];
            tab[0] = 1;
            tab[1] = 2;
            tab[2] = 3;
            Table_Task(tab);
            Console.WriteLine("After:");
            foreach(int i in tab) Console.WriteLine(i);
            Console.WriteLine("Nadpisanie tablicy:");
            Nadpisanie_Tablicy(tab);
            Console.WriteLine("Po:");
            foreach (int i in tab) Console.WriteLine(i);
            Console.WriteLine("referencyjne nadpisanie:");
            Nadpisanie_Tablicy_V2(ref tab);
            foreach (int i in tab) Console.WriteLine(i);
        }

        private static void Nadpisanie_Tablicy_V2(ref int[] tab)
        {
            tab = new int[1];
            tab[0] = 666;
            Console.WriteLine(tab[0]);
            foreach (int i in tab) Console.WriteLine(i);
        }

        private static void Nadpisanie_Tablicy(int[] tab)
        {
            tab = new int[4];
            tab[0] = 1;
            tab[1] = 2;
            tab[2] = 3;
            tab[3] = 4;
            foreach (int i in tab) Console.WriteLine(i);
        }

        private static void Table_Task(int[] tab)
        {
            tab[0] *= 2;
            tab[1] *= 2;
            tab[2] *= 2;
            foreach (int i in tab)
                    Console.WriteLine(i);
        }

        private static string Zamieniacz(int zmienna)
        {
            return zmienna.ToString();
        }

        private static int Dodaj(int a, int b)
        {
            return a + b;
        }

        private static void Summer2(int a, int b=0, int c=0)
        {
            Console.WriteLine("Summer3 (only value)= {0}",a+b+c);
        }

        private static void Summer(int a, int b, int c)
        {
            Console.WriteLine("Overloaded function of summing up 3 ints= {0}",a+b+c);
        }

        private static void Summer(int a, int b)
        {
            Console.WriteLine("Sum of 2 is: {0}",a+b);


        }
    }
}
