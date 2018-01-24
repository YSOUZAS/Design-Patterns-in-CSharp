using System;
namespace Design_Patterns_in_CSharp.Proxy
{
    public interface ISubject
    {
        void DoAction();
    }


    public class RealSubject : ISubject
    {
        private string s;

        public RealSubject(string s) => this.s = s;
        public void DoAction() => Console.WriteLine("`doAction` of RealSubject" + this.s + "is being called!");
    }



    public class Proxy : ISubject
    {
        private RealSubject realSubject;
        private string s;

        public Proxy(string s) => this.s = s;

        public void DoAction()
        {
            Console.WriteLine("`doAction` of Proxy(" + this.s + ")");
            if (this.realSubject == null)
            {
                Console.WriteLine("creating a new RealSubject.");
                this.realSubject = new RealSubject(this.s);
            }
            this.realSubject.DoAction();
        }
    }
}
