
using System;

namespace TurDonusumleri
{

    class Program{ 
    static void Main(String[] args)
        {
            int a = 5;
            byte b = (byte)a;

            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}