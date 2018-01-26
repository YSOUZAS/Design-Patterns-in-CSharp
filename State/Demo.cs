using System;
namespace Design_Patterns_in_CSharp.State
{
    public class Demo
    {
        public Demo()
        {
        }
        public void Show()
        {
            var context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }
}
