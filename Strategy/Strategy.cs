using System;
namespace Design_Patterns_in_CSharp.Strategy
{
    public interface IStrategy
    {
        void Execute();
    }

    public class ConcreteStrategy1 : IStrategy
    {
        public void Execute() => Console.WriteLine("`execute` method of ConcreteStrategy1 is being called");
    }

    public class ConcreteStrategy2 : IStrategy
    {
        public void Execute() => Console.WriteLine("`execute` method of ConcreteStrategy2 is being called");
    }
    public class ConcreteStrategy3 : IStrategy
    {
        public void Execute() => Console.WriteLine("`execute` method of ConcreteStrategy3 is being called");
    }

    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy) => this.strategy = strategy;

        public void ExecuteStrategy() => this.strategy.Execute();
    }
}
