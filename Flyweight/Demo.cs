using System;
namespace Design_Patterns_in_CSharp.Flyweight
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show(){
            var factory = new FlyweightFactory();

            var conc1 = factory.GetFlyweight("conc1");
            var conc2 =  factory.GetFlyweight("conc1");

            conc1.Operation("1");
            conc2.Operation("2");
        }
    }
}
