using System;
namespace Design_Patterns_in_CSharp.Strategy
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {
            var context = new Context(new ConcreteStrategy1());
            context.ExecuteStrategy();

            context = new Context(new ConcreteStrategy2());
            context.ExecuteStrategy();

            context = new Context(new ConcreteStrategy3());
            context.ExecuteStrategy();
        }
    }
}
