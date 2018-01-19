using System;
using System.Collections.Generic;
namespace Design_Patterns_in_CSharp.Composite
{

    public interface IComponent
    {
        void Operation();
    }

    public class Composite : IComponent
    {
        private LinkedList<IComponent> list;
        private string s;

        public Composite(string s)
        {
            this.list = new LinkedList<IComponent>();
            this.s = s;
        }

        public void Operation()
        {
            Console.WriteLine("`operation of `" + this.s);
            foreach (var item in this.list)
            {
                item.Operation();
            }
        }

        public void Add(IComponent c) => this.list.AddLast(c);

        public void Remove(IComponent c) => this.list.Remove(c);
    }
    public class Leaf : IComponent
    {
        private string s;

        public Leaf(string s) => this.s = s;

        public void Operation() => Console.WriteLine("`operation` of Leaf " + this.s + " is called.");
    }
}

