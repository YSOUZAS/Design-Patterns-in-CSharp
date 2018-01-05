using System;
using Design_Patterns_in_CSharp.Command;


namespace Design_Patterns_in_CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var DemoAdapter = new Demo();
            DemoAdapter.Show();
        }
    }
}
