using System;
using System.Security.Cryptography.X509Certificates;
namespace Design_Patterns_in_CSharp.Adapter
{

    public interface Target
    {
        void Call();
    }

    public class Adaptee
    {
        public void Method() => Console.WriteLine("`method` of Adaptee is being called");
    }


    public class Adapter : Target
    {
        public void Call()
        {
            Console.WriteLine("Adapter's `call` method is being called");
            var adaptee = new Adaptee();
            adaptee.Method();
        }
    }
}
