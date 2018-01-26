using System;
namespace Design_Patterns_in_CSharp.State
{
    public class Context
    {
        private IState state;

        public Context(IState state) => this.state = state;
        public IState State { get => state; set => state = value; }
        public void Request()
        {
            Console.WriteLine("request is being called!");
            this.state.Handle(this);
        }
    }

    public interface IState
    {
        void Handle(Context context);
    }

    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("`handle` method of ConcreteStateA is being called!");
            context.State = new ConcreteStateB();
        }
    }
    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("`handle` method of ConcreteStateB is being called!");
            context.State = new ConcreteStateA();
        }
    }

}
