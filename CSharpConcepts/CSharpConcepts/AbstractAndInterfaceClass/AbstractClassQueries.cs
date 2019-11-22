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
            throw new NotImplementedException();
        }
    }
}
