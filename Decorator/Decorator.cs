using System;
namespace Design_Patterns_in_CSharp.Decorator
{
    public interface IComponent
    {
        void Operation();
    }

    public class ConcreteComponent : IComponent
    {
        private string s;

        public ConcreteComponent(string s) => this.s = s;

        public void Operation() => Console.WriteLine("`operation` of ConcreteComponent " + this.s + " is being called!");
    }

    public class Decorator : IComponent
    {
        private IComponent component;
        private int id;

        public Decorator(IComponent component, int id)
        {
            this.component = component;
            this.id = id;
        }

        public int Id { get => id; }

        public void Operation()
        {
            Console.WriteLine("`operation` of Decorator " + this.id + " is being called!");
            this.component.Operation();
        }

    }

    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(IComponent component, int id) : base(component, id)
        {
        }

        public new void Operation()
        {
            base.Operation();
            Console.WriteLine("`operation` of ConcreteDecorator", this.Id, " is being called!");
        }
    }


}
