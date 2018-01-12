using System;
using System.Collections;
using System.Collections.Generic;

namespace Design_Patterns_in_CSharp.Visitor
{

    public interface Element
    {
        void Operate(Visitor visitor);
    }

    public class ConcreteElement1 : Element
    {
        public void Operate(Visitor visitor)
        {
            Console.WriteLine("`operate` of ConcreteElement1 is being called!");
            visitor.VisitConcreteElement1(this);
        }
    }

    public class ConcreteElement2 : Element
    {
        public void Operate(Visitor visitor)
        {
            Console.WriteLine("`operate` of ConcreteElement2 is being called!");
            visitor.visitConcreteElement2(this);
        }
    }

    public class ConcreteVisitor1 : Visitor
    {
        public void VisitConcreteElement1(ConcreteElement1 concreteElement1)
        {
            Console.WriteLine("`visitConcreteElement1` of ConcreteVisitor1 is being called!");
        }

        public void visitConcreteElement2(ConcreteElement2 concreteElement2)
        {
            Console.WriteLine("`visitConcreteElement2` of ConcreteVisitor2 is being called!");
        }
    }

    public class ConcreteVisitor2 : Visitor
    {
        public void VisitConcreteElement1(ConcreteElement1 concreteElement1)
        {
            Console.WriteLine("`visitConcreteElement1` of ConcreteVisitor1 is being called!");
        }

        public void visitConcreteElement2(ConcreteElement2 concreteElement2)
        {
            Console.WriteLine("`visitConcreteElement2` of ConcreteVisitor2 is being called!");
        }
    }

    public interface Visitor
    {
        void VisitConcreteElement1(ConcreteElement1 concreteElement1);
        void visitConcreteElement2(ConcreteElement2 concreteElement2);

    }

    public class Objs{
        private LinkedList<Element> elements = new LinkedList<Element>();

        public void attach(Element e){
            this.elements.AddLast(e);
        }

        public void detach(Element e){
            this.elements.Remove(e);
        }

        public void Operate(Visitor visitor){
            foreach (var item in this.elements)
            {
                item.Operate(visitor);
            }
        }
    }
}
