using System;
namespace Design_Patterns_in_CSharp.Mediator
{
    public class Demo
    {
        public Demo()
        {
        }
        public void Show()
        {
            var cm = new ConcreteMediator();
            var c1 = new ConcreteColleagueA(cm);
            var c2 = new ConcreteColleagueB(cm);

            cm.concreteColleagueA = c1;
            cm.concreteColleagueB = c2;

            c1.Send("`send` of ConcreteColleagueA is being called!");
            c2.Send("`send` of ConcreteColleagueB is being called!");

        }
    }
}
