using System;

namespace InterfaceDemo
{
    class Program
    {
        private static object obj = "test";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Document store = new Document();
            Print(store);
        }
        static void Print(IStorable store)
        {
            store.Read();
        }
    }

 
}
