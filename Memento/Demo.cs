using System;
namespace Design_Patterns_in_CSharp.Memento
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {
            var state = new State("... State ");
            var originator = new Originator(state);
            var careTaker = new CareTaker
            {
                Memento = originator.CreateMemento()
            };

            originator.State = new State("something else...");

            originator.SetMemento(careTaker.Memento);
        }
    }
}
