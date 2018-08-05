using System;
namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];
            string name1 = args[1];
            string name2 = args[2];

            Console.WriteLine("witaj, " + name + "\nwitaj, " + name1 + "\nwitaj, " + name2);


            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj, " + item);

            //}
        }
    }
}
