using System;
namespace Design_Patterns_in_CSharp.ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler handler;
        private int req;

        public void SetHandler(Handler value) => handler = value;

        protected Handler(int req) => this.req = req;
        public void Operation(string msg, int req)
        {
            if (req <= this.req)
                this.HandlerRequest(msg);
            else if (this.handler != null)
                this.handler.Operation(msg, req);
        }

        public abstract void HandlerRequest(string msg);

    }

    public class ConcreteHandler1 : Handler
    {
        public ConcreteHandler1(int req) : base(req)
        {
        }
        public override void HandlerRequest(string msg) => Console.WriteLine("Message (ConcreteHandler1) :: " + msg);
    }
    public class ConcreteHandler2 : Handler
    {
        public ConcreteHandler2(int req) : base(req)
        {
        }
        public override void HandlerRequest(string msg) => Console.WriteLine("Message (ConcreteHandler2) :: " + msg);
    }
    public class ConcreteHandler3 : Handler
    {
        public ConcreteHandler3(int req) : base(req)
        {
        }
        public override void HandlerRequest(string msg) => Console.WriteLine("Message (ConcreteHandler3) :: " + msg);
    }
}
