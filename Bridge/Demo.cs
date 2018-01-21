using System;
namespace Design_Patterns_in_CSharp.Bridge
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {
            var abstractionA = new RefinedAbstractionA(new ConcreteImplementorA());
            var abstractionB = new RefinedAbstractionB(new ConcreteImplementorB());

            abstractionA.CallIt("abstractionA");
            abstractionB.CallIt("abstractionB");

        }


    }
}
