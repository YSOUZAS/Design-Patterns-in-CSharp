using System;
namespace Design_Patterns_in_CSharp.Proxy
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {
            var proxy1 = new Proxy("proxy1");
            var proxy2 = new Proxy("proxy2");

            proxy1.DoAction();
            proxy1.DoAction();
            proxy2.DoAction();
            proxy2.DoAction();
            proxy1.DoAction();
        }
    }
}
