using System;
namespace Design_Patterns_in_CSharp.Observer
{
    public class Demo
    {
        public Demo()
        {
        }


        public void Show()
        {
            var sub = new ConcreteSubject();
            sub.Register(new ConcreteObserver("Jancsi", sub));
            sub.Register(new ConcreteObserver("Julcsa", sub));
            sub.Register(new ConcreteObserver("Marcsa", sub));


            sub.SubjectState = 123;
            sub.Notify();
        }
    }
}
