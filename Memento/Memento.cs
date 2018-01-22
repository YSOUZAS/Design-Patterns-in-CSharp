using System;
namespace Design_Patterns_in_CSharp.Memento
{
    public class State
    {
        private String str;

        public State(string str) => this.str = str;
        public string Str { get => str; set => str = value; }
    }

    public class Originator
    {
        private State state;

        public Originator(State state) => this.state = state;
        public State State { get => state; set => state = value; }
        public Memento CreateMemento()
        {
            Console.WriteLine("creates a memento with a given state!");
            return new Memento(this.state);
        }
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("sets the state back");
            this.state = memento.State;
        }
    }

    public class Memento
    {
        private State state;

        public Memento(State state) => this.State = state;
        public State State { get { Console.WriteLine("get memento's state"); return state; } set => state = value; }
    }

    public class CareTaker
    {
        private Memento memento;
        public Memento Memento { get => memento; set => memento = value; }
    }
}
