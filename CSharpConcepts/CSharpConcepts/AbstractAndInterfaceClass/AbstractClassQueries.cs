using System;

namespace CSharpConcepts.AbstractAndInterfaceClass
{
    class AbstractClassQueries
    {
    }
    /// <summary>
    /// Consider this class as A.
    /// </summary>        
    public abstract class Employee
    {
        //if we declare property "sumValue" non static then it will not be accessible in the static constructor "Employee".
        //public int SumValue = 10;

        //To make property sumValue accessible in the "Employee" constructor we need to make it static.
        public static int SumValue = 10;

        static Employee()
        {
            SumValue = 20;
            Sum();
        }

        //By default constructor is private so it will not be accessible in the class "FullTimeEmployee". To overcome this problem declare it as public/protected.
        //Employee()
        //{
        //        
        //}

        protected Employee()
        {
                
        }

        //if we declare method "sum" non static then it will not be accessible in the static constructor "Employee".
        //public int Sum()
        //{
        //    return SumValue + SumValue;
        //}

        //To make method "Sum" accessible in the "Employee" constructor it must be static.
        public static int Sum()
        {
            return SumValue + SumValue;
        }

        public abstract string Print();

    }

    /// <summary>
    /// Consider this class as B.
    /// Question: What if I don't wants to implement "Print" method in the class "B" but wants to implement in the class "C".?
    /// Answer: Make class B as abstract and derive class B in the the class C.
    /// </summary>
    public abstract class FullTimeEmployee : Employee
    {

    }

    /// <summary>
    /// Consider this class as C.
    /// </summary>
    public class Abc : FullTimeEmployee
    {
        public override string Print()
        {

            //throw new NotImplementedException();
            return $"Summation is: {Sum()}";
        }
    }

    class Program
    {
        public static void AbstractClassWithVirtualMethodMain()
        {
            Abc sc = new Abc();
            sc.Print();

            Console.ReadKey();
        }
    }
}
