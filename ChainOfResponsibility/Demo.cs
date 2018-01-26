using System;
using System.Collections.Generic;
namespace Design_Patterns_in_CSharp.ChainOfResponsibility
{
    public class Demo
    {
        public Demo()
        {
        }
        public void Show()
        {
            var reqs = new List<int>
            {
                2,
                7,
                23,
                34,
                4,
                5,
                8,
                3
            };

            var h1 = new ConcreteHandler1(3);
            var h2 = new ConcreteHandler2(7);
            var h3 = new ConcreteHandler3(20);

            h1.SetHandler(h2);
            h2.SetHandler(h3);

            foreach (var req in reqs)
                h1.Operation("operation is fired!", req);
        }
    }
}
