using System;
namespace Design_Patterns_in_CSharp.Decorator
{
    public class Demo
    {
        public Demo()
        {
        }


        public void Show()
        {
            var decorator1 = new ConcreteDecorator(new ConcreteComponent("Comp1"), 1);

            decorator1.Operation();
        }
    }
}
