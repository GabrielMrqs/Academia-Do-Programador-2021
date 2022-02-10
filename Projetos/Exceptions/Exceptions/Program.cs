using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            DataValida data1 = new DataValida(29, 02, 2020);
            Console.WriteLine(data1 + "\n"); 

            DataValida data2 = new DataValida(29, 02, 2021);
            Console.WriteLine(data2 + "\n"); 

            DataValida data3 = new DataValida(22, 06, 2001);
            Console.WriteLine(data3 + "\n"); 

            DataValida data4 = new DataValida(35, 02, 2019);
            Console.WriteLine(data4 + "\n"); 

            DataValida data5 = new DataValida(29, 13, 2015);
            Console.WriteLine(data5 + "\n"); 

            Console.ReadLine();
        }
    }
}
