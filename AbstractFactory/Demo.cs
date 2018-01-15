using System;
using static Design_Patterns_in_CSharp.AbstractFactory.AbstractFactory;

namespace Design_Patterns_in_CSharp.AbstractFactory
{
    public class Demo
    {
        public Demo()
        {
        }


        public void Show()
        {
            var tester1 = new Tester(new ConcreteFactory1());
            tester1.Test();

            var tester2 = new Tester(new ConcreteFactory2());
            tester2.Test();
        }
    }
}
