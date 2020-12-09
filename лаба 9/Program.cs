using System;
using System.IO;

namespace лаба_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Откройте док-нт 1.txt");
            string name = Console.ReadLine();
            Console.WriteLine(File.ReadAllText(name));
            string doc = File.ReadAllText(name);
            string[] a = doc.Split(' ');
            string min = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if (a[i].Length < min.Length)
                    min = a[i];
            }
            Console.WriteLine(min);

        }
    }
}
