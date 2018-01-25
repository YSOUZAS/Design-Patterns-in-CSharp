using System;
namespace Design_Patterns_in_CSharp.Mediator
{
    public abstract class Colleague
    {
        public IMediator mediator;

        protected Colleague(IMediator mediator) => this.mediator = mediator;
        public abstract void Send(string msg);
        public abstract void Receive(string msg);

    }
    public interface IMediator
    {
        void Send(string msg, Colleague colleague);
    }
    public class ConcreteColleagueB : Colleague
    {
        public ConcreteColleagueB(IMediator mediator) : base(mediator)
        {
        }

        public override void Receive(string msg) => Console.WriteLine(msg + " `receive` of ConcreteColleagueB is being called!");
        public override void Send(string msg) => this.mediator.Send(msg, this);
    }
    public class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(IMediator mediator) : base(mediator)
        {
        }

        public override void Receive(string msg) => Console.WriteLine(msg + " `receive` of ConcreteColleagueA is being called!");
        public override void Send(string msg) => this.mediator.Send(msg, this);
    }
    public class ConcreteMediator : IMediator
    {
        public ConcreteColleagueA concreteColleagueA;
        public ConcreteColleagueB concreteColleagueB;

        public void Send(string msg, Colleague colleague)
        {
            if (this.concreteColleagueA == colleague)
                this.concreteColleagueB.Receive(msg);
            else this.concreteColleagueA.Receive(msg);
        }
    }


}
