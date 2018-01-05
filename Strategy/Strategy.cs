using System;
namespace Design_Patterns_in_CSharp.Strategy
{
    public interface Strategy
    {
        void Execute();
    }

    public class ConcreteStrategy1 : Strategy
    {
        public void Execute()
        {
            Console.WriteLine("`execute` method of ConcreteStrategy1 is being called");
        }
    }

    public class ConcreteStrategy2 : Strategy
    {
        public void Execute()
        {
            Console.WriteLine("`execute` method of ConcreteStrategy2 is being called");
        }
    }
    public class ConcreteStrategy3 : Strategy
    {
        public void Execute()
        {
            Console.WriteLine("`execute` method of ConcreteStrategy3 is being called");
        }
    }

    public class Context
    {
        private Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            this.strategy.Execute();
        }
    }
}
