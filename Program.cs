using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Toplama(3, 2);
            Toplama(1, 2, 6);
            Console.ReadLine();
        }

        public static void Toplama(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine("{0},{1},{2}", sayi1, sayi2, sayi3);
        }

        public static void Toplama(int sayi1, int sayi2)
        {
            Console.WriteLine("{0},{1}", sayi1, sayi2);
        }
    }
}