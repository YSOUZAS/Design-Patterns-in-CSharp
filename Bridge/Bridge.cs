using System;
namespace Design_Patterns_in_CSharp.Bridge
{
    public interface IImplementor
    {
        void CallEe(string s);
    }

    public abstract class Abstraction
    {
        public IImplementor implementor;

        protected Abstraction(IImplementor implementor) => this.implementor = implementor;
        public virtual void CallIt(string s) => Console.Error.WriteLine("This method is abstract!");
    }

    public class RefinedAbstractionA : Abstraction
    {
        public RefinedAbstractionA(IImplementor implementor) : base(implementor)
        {
        }
        public override void CallIt(string s)
        {
            Console.WriteLine("This is RefinedAbstractionA");
            this.implementor.CallEe(s);
        }
    }
    public class RefinedAbstractionB : Abstraction
    {
        public RefinedAbstractionB(IImplementor implementor) : base(implementor)
        {
        }
        public override void CallIt(string s)
        {
            Console.WriteLine("This is RefinedAbstractionB");
            this.implementor.CallEe(s);
        }
    }
    public class ConcreteImplementorA : IImplementor
    {
        public void CallEe(string s)
        {
            Console.WriteLine("`callee` of ConcreteImplementorA is being called.");
            Console.WriteLine(s);
        }
    }
    public class ConcreteImplementorB : IImplementor
    {
        public void CallEe(string s)
        {
            Console.WriteLine("`callee` of ConcreteImplementorB is being called.");
            Console.WriteLine(s);
        }
    }

}
