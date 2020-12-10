using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Jane";
            byte MyAge = 27;
            bool HaveIPet = true;
            double MyShoeSize = 37.5;

            Console.WriteLine("My Name is " + MyName);
            Console.WriteLine("My Age is " + MyAge);
            Console.WriteLine("Do I have a pet " + HaveIPet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.ReadKey();

        }
    }
}
