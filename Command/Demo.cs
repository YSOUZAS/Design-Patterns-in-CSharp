using System;
namespace Design_Patterns_in_CSharp.Command
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {
            var receiver = new Receiver();
            var command1 = new ConcreteCommand1(receiver);
            var command2 = new ConcreteCommand2(receiver);
            var invoker = new Invoker();

            invoker.StoreAndExecute(command1);
            invoker.StoreAndExecute(command2);
        }
    }
}
