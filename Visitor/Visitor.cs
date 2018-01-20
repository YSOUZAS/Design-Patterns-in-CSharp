using System;
using System.Collections;
using System.Collections.Generic;

namespace Design_Patterns_in_CSharp.Visitor
{

    public interface IElement
    {
        void Operate(IVisitor visitor);
    }

    public class ConcreteElement1 : IElement
    {
        public void Operate(IVisitor visitor)
        {
            Console.WriteLine("`operate` of ConcreteElement1 is being called!");
            visitor.VisitConcreteElement1(this);
        }
    }

    public class ConcreteElement2 : IElement
    {
        public void Operate(IVisitor visitor)
        {
            Console.WriteLine("`operate` of ConcreteElement2 is being called!");
            visitor.VisitConcreteElement2(this);
        }
    }

    public class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteElement1(ConcreteElement1 concreteElement1) => Console.WriteLine("`visitConcreteElement1` of ConcreteVisitor1 is being called!");

        public void VisitConcreteElement2(ConcreteElement2 concreteElement2) => Console.WriteLine("`visitConcreteElement2` of ConcreteVisitor2 is being called!");
    }

    public class ConcreteVisitor2 : IVisitor
    {
        public void VisitConcreteElement1(ConcreteElement1 concreteElement1) => Console.WriteLine("`visitConcreteElement1` of ConcreteVisitor1 is being called!");

        public void VisitConcreteElement2(ConcreteElement2 concreteElement2) => Console.WriteLine("`visitConcreteElement2` of ConcreteVisitor2 is being called!");
    }

    public interface IVisitor
    {
        void VisitConcreteElement1(ConcreteElement1 concreteElement1);
        void VisitConcreteElement2(ConcreteElement2 concreteElement2);

    }

    public class Objs{
        private LinkedList<IElement> elements = new LinkedList<IElement>();

        public void Attach(IElement e) => this.elements.AddLast(e);

        public void Detach(IElement e) => this.elements.Remove(e);

        public void Operate(IVisitor visitor){
            foreach (var item in this.elements)
            {
                item.Operate(visitor);
            }
        }
    }
}
