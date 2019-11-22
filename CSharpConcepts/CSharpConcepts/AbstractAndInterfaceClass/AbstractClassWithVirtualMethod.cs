using System;

namespace CSharpConcepts.AbstractAndInterfaceClass
{
    public abstract class AbstractClassWithVirtualMethod
    {
        public virtual void AbstractClassMethod()
        {
            Console.WriteLine("Default Implementation");
        }
    }

    public class SomeClass : AbstractClassWithVirtualMethod
    { }

    public class SomeOtherClass : AbstractClassWithVirtualMethod
    {
        public override void AbstractClassMethod()
        {
            Console.WriteLine("New Implementation");
        }
    }

    class Program
    {
        public static void AbstractClassWithVirtualMethodMain()
        {
            SomeClass sc = new SomeClass();
            sc.AbstractClassMethod();

            SomeOtherClass soc = new SomeOtherClass();
            soc.AbstractClassMethod();

            Console.ReadKey();
        }
    }
}