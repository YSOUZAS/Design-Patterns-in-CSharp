using System;
namespace Design_Patterns_in_CSharp.TemplateMethod
{
    public class Demo
    {
        public Demo()
        {
        }
        public void Show()
        {
            var c1 = new ConcreteClass1();
            var c2 = new ConcreteClass2();

            c1.TemplateMethod();
            c2.TemplateMethod();
        }
    }
}
