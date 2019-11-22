using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharpConcepts.AbstractAndInterfaceClass
{
    class AbstractClassQueAns
    {
    }


    /// <summary>
    /// AbstractClassOne and AbstractClassTwo are abstract classes.
    /// ICustomer is an interface.
    /// Que Ans. Below statement is this Possible? 
    /// No -> Customer : AbstractClassOne
    /// 
    /// Yes -> AbstractClassOne : Customer
    /// 
    /// Yes -> AbstractClassOne : ICustomer
    /// 
    /// Yes -> AbstractClassOne : Customer, ICustomer
    /// 
    /// Yes -> AbstractClassOne : AbstractClassTwo, 
    /// 
    /// Yes -> AbstractClassOne : AbstractClassTwo, ICustomer
    /// 
    /// </summary>
    /// <seealso cref="AbstractClassOne" />
    public class Customer : AbstractClassOne, ICustomer
    {
        public override string GetCurrentUtcDateTime()
        {
            return DateTime.UtcNow.ToString(CultureInfo.InvariantCulture);
        }

        public string GetCustomerFirstName()
        {
            return "Jay";
        }
    }
 
    public interface ICustomer
    {
        //Constructor is not possible
        //public ICustomer()
        //{
        //        
        //}

        //Static method is not possible
        //static string GetCustomerName()
        //{
        //    return "Jay Mistry";
        //}

        // Trying to create constructor for interface but it is not allowed to create constructor of an interface.
        //CS0526	Interfaces cannot contain constructors
        //public ICustomer()
        //{
        //}

        //interface members cannot have a definition
        //string GetCustomerName()
        //{ //Interface method can not declare a body
        //
        //    return "Jay Mistry";
        //}

        string GetCustomerFirstName();
    }

    public abstract class AbstractClassOne
    {
        //We can write Static method in abstract class
        public static string GetStringData()
        {
            return "This is a demo string.";
        }

        //1. Constructor is possible
        //2. Public constructor is not required. Use Protected Access Modifier.
        //public AbstractClassOne()
        //{
        //
        //}

        //Making constructor as Protected is the best practice.
        //Because we can not create an instance of an abstract class so no need to make it as public constructor.
        protected AbstractClassOne()
        {

        }

        //This is the signature of the method.
        public abstract string GetCurrentUtcDateTime();

        private string GetCurrentUtcTime()
        {
            return DateTime.UtcNow.ToShortTimeString();
        }
    }
}
