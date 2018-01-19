using System;
namespace Design_Patterns_in_CSharp.Composite
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {
            var leaf1 = new Leaf("1");
            var leaf2 = new Leaf("2");
            var leaf3 = new Leaf("3");

            var composite1 = new Composite("Comp1");
            var composite2 = new Composite("Comp2");


            composite1.Add(leaf1);
            composite1.Add(leaf2);
            composite1.Add(leaf3);

            composite1.Add(leaf2);

            composite2.Add(leaf1);
            composite2.Add(leaf3);

            composite1.Operation();
            composite1.Operation();



        }
    }
}
