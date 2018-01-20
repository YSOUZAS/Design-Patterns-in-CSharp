using System;
namespace Design_Patterns_in_CSharp.Facade
{
    public class Part1
    {
        public void Method1() => Console.WriteLine("`method1` of Part1");
    }

    public class Part2
    {
        public void Method2() => Console.WriteLine("`method2` of Part2");
    }

    public class Part3
    {
        public void Method3() => Console.WriteLine("`method3` of Part2");
    }

    public class Facade
    {
        private Part1 part1 = new Part1();
        private Part2 part2 = new Part2();
        private Part3 part3 = new Part3();

        public void Operation1(){
            Console.WriteLine("`operation1` is called ===");
            this.part1.Method1();
            this.part2.Method2();
            Console.WriteLine("==========================");
        }

        public void Operation2()
        {
            Console.WriteLine("`operation2` is called ===");
            this.part1.Method1();
            this.part3.Method3();
            Console.WriteLine("==========================");
        }
    }
}
