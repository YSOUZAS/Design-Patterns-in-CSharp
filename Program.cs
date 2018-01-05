using System;
using Design_Patterns_in_CSharp.Strategy;

namespace Design_Patterns_in_CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var DemoStrategy = new Demo();
            DemoStrategy.Show();
        }
    }
}
