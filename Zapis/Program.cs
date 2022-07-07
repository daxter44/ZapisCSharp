using System;
using System.IO;
using System.Threading;

namespace ZapisDoPliku
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("plik.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 0; i < 101; i++)
            {
                file.WriteByte((byte)i);
            }
            file.Position = 0;
            Thread.Sleep(100000);
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(file.ReadByte());
            }
            file.Close();
            Console.ReadKey();
            var wynikDodawania = DodajLiczby(5, 6);
        }


        public static int DodajLiczby(int a, int b)
        {
            return a + b;
        }
    }
}
