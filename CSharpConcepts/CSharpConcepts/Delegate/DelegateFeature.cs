using System.Buffers.Text;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CSharpConcepts.Delegate
{
    // Delegate Declaration. 
    public delegate int HelloFunctionDelegate(int firstValue, int secondValue);

    /// <summary>
    ///
    /// C# | Delegates
    /// 
    /// A delegate is an object which refers to a method or you can say it is a reference type variable that can hold a reference to the methods.
    /// Delegates in C# are similar to the function pointer in C/C++. It provides a way which tells which method is to be called when an event is triggered.
    /// For example, if you click an Button on a form (Windows Form application), the program would call a specific method.In simple words,
    /// it is a type that represents references to methods with a particular parameter list and return type and then calls the method in a program for execution when it is needed.
    ///
    /// Multicasting of a Delegate
    /// Multicasting of delegate is an extension of the normal delegate (sometimes termed as Single Cast Delegate). It helps the user to point more than one method in a single call.
    ///
    /// https://www.geeksforgeeks.org/c-sharp-delegates/
    /// https://www.c-sharpcorner.com/UploadFile/84c85b/delegates-and-events-C-Sharp-net/
    /// 
    /// </summary>
    public class DelegateFeature
    {
        public static int Multiplication(int firstValue, int secondValue)
        {
            return firstValue * secondValue;
        }

        public static int Summation(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }
        public int Dividation(int firstValue, int secondValue)
        {
            return firstValue / secondValue;
        }

        public static void TestMethod()
        {
            //First way

            //Do the multiplication
            HelloFunctionDelegate deligateObject = new HelloFunctionDelegate(Multiplication);

            // pass the values to the methods by delegate object 
            deligateObject(1, 2);

            //Do the Summation
            deligateObject = Summation; //Remove redundant delegate constructor call -> removed -> new HelloFunctionDelegate(Summation)

            // pass the values to the methods by delegate object 
            deligateObject(5, 7);
        }
    }

    class Program
    {
        public static void DelegateFeatureMain()
        {
            //Second Way
            // Creating object "obj" of class "DelegateFeature" 
            DelegateFeature abstractClassObject = new DelegateFeature();
    
            //Do the Dividation
            // creating object of delegate, name as "deligateObject2"  
            // for method "Dividation" & pass the parameter as the two methods by class object "obj" 
            // instantiating the delegates 
            HelloFunctionDelegate deligateObject2 = new HelloFunctionDelegate(abstractClassObject.Dividation);
    
            // pass the values to the methods by delegate object 
            deligateObject2(6, 2);
    
            deligateObject2.Invoke(100, 40);
        }
    }
}
