using System;
using System.Collections.Generic;
namespace Design_Patterns_in_CSharp.Command
{
    public abstract class Command
    {
        public abstract void Execute();
    }

    public class ConcreteCommand1 : Command
    {
        private Receiver receiver;

        public ConcreteCommand1(Receiver receiver) => this.receiver = receiver;

        public override void Execute()
        {
            Console.WriteLine("`execute` method of ConcreteCommand1 is being called!");
            this.receiver.Action();
        }
    }

    public class ConcreteCommand2 : Command
    {
        private Receiver receiver;

        public ConcreteCommand2(Receiver receiver) => this.receiver = receiver;

        public override void Execute()
        {
            Console.WriteLine("`execute` method of ConcreteCommand2 is being called!");
            this.receiver.Action();
        }
    }

    public class Invoker
    {
        private ICollection<Command> commands;

        public Invoker() => this.commands = new LinkedList<Command>();

        public void StoreAndExecute(Command cmd)
        {
            this.commands.Add(cmd);
            cmd.Execute();
        }
    }
    public class Receiver
    {
        public void Action() => Console.WriteLine("action is being called!");
    }


}
