using CSharpConcepts.AbstractAndInterfaceClass;
using System;

namespace CSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            //For working with "AbstractAndInterfaceClass".
            Abc sc = new Abc();
            Console.WriteLine(sc.Print());

            Console.ReadKey();
        }
    }
}
