using System;
using System.Collections.Generic;
namespace Design_Patterns_in_CSharp.Observer
{

    public abstract class Observer
    {
        public virtual void Notify() => Console.Error.WriteLine("Abstract Method!");
    }

    public class Subject
    {
        private LinkedList<Observer> observers = new LinkedList<Observer>();

        public void Register(Observer observer)
        {
            Console.WriteLine(observer + " is pushed!");
            this.observers.AddLast(observer);
        }

        public void Unregister(Observer observer)
        {
            Console.WriteLine(observer + " is removed!");
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in this.observers)
                item.Notify();
        }

    }

    public class ConcreteSubject : Subject
    {
        private int subjectState;
        public int SubjectState { get => subjectState; set => subjectState = value; }
    }

    public class ConcreteObserver : Observer
    {
        private string name;
        private int state;
        private ConcreteSubject subject;

        public ConcreteObserver(string name, ConcreteSubject subject)
        {
            Console.WriteLine("ConcreteObserver " + name + " is created!");
            this.name = name;
            this.subject = subject;
        }

        public override void Notify()
        {
            Console.WriteLine("ConcreteObserver's notify method");
            Console.WriteLine(this.name, this.state);
            this.state = this.subject.SubjectState;
        }

        public ConcreteSubject Subject { get => subject; set => subject = value; }
    }






}
