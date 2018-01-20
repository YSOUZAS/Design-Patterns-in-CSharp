using System;
namespace Design_Patterns_in_CSharp.Facade
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {
            var facade = new Facade();
            facade.Operation1();
            facade.Operation2();
        }
    }

}
