using System;
namespace Design_Patterns_in_CSharp.TemplateMethod
{
    public abstract class AbstractClass
    {
        public abstract void Method1();
        public abstract void Method2();
        public abstract void Method3();


        public void TemplateMethod()
        {
            Console.WriteLine("templateMethod is being called");
            this.Method1();
            this.Method2();
            this.Method3();
        }
    }

    public class ConcreteClass1 : AbstractClass
    {
        public override void Method1() => Console.WriteLine("method1 of ConcreteClass1");
        public override void Method2() => Console.WriteLine("method2 of ConcreteClass1");
        public override void Method3() => Console.WriteLine("method3 of ConcreteClass1");
    }
    public class ConcreteClass2 : AbstractClass
    {
        public override void Method1() => Console.WriteLine("method1 of ConcreteClass2");
        public override void Method2() => Console.WriteLine("method2 of ConcreteClass2");
        public override void Method3() => Console.WriteLine("method3 of ConcreteClass2");
    }
}
