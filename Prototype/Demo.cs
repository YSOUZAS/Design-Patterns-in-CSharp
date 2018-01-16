using System;
namespace Design_Patterns_in_CSharp.Prototype
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {
            var builder = new Builder();
            var i = 0;
            for (i = 1; i <= 3; i += 1)
            {
                Console.WriteLine(builder.CreateOne("c" + i).ToString());
            }
        }
    }
}
