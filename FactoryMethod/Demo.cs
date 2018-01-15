using System;
namespace Design_Patterns_in_CSharp.FactoryMethod
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {
            var a = ProductFactory.CreateProduct("A");
            var b = ProductFactory.CreateProduct("B");

            Console.WriteLine(a.Method());
            Console.WriteLine(b.Method());

        }
    }
}
