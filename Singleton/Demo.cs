using System;
namespace Design_Patterns_in_CSharp.Singleton
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {
            var Singleton1 = Singleton.Instance();
            var Singleton2 = Singleton.Instance();

            if (Singleton1 == Singleton2)
                Console.Write("two singletons are equivalent");
            else
                Console.WriteLine("two singletons are not equivalent");
        }
    }
}
