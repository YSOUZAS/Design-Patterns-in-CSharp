using System;
namespace Design_Patterns_in_CSharp.AbstractFactory
{
    public class AbstractFactory
    {

        public interface IAbstractProductA
        {
            String MethodA();
        }

        public interface IAbstractProductB
        {
            int MethodB();
        }

        public interface IAbstractFactory
        {
            IAbstractProductA CreatePorductA();
            IAbstractProductB CreatePorductB();

        }

        public class ProductA1 : IAbstractProductA
        {
            public string MethodA()
            {
                return "This is methodA of ProductA1";
            }
        }

        public class ProductA2 : IAbstractProductA
        {
            public string MethodA()
            {
                return "This is methodA of ProductA2";
            }
        }

        public class ProductB1 : IAbstractProductB
        {
            public int MethodB()
            {
                return 1;
            }
        }

        public class ProductB2 : IAbstractProductB
        {
            public int MethodB()
            {
                return 2;
            }
        }

        public class ConcreteFactory1 : IAbstractFactory
        {
            public IAbstractProductA CreatePorductA()
            {
                return new ProductA1();
            }

            public IAbstractProductB CreatePorductB()
            {
                return new ProductB1();
            }
        }

        public class ConcreteFactory2 : IAbstractFactory
        {
            public IAbstractProductA CreatePorductA()
            {
                return new ProductA2();
            }

            public IAbstractProductB CreatePorductB()
            {
                return new ProductB2();
            }
        }


        public class Tester
        {
            private IAbstractProductA abstractProductA;
            private IAbstractProductB abstractProductB;

            public Tester(IAbstractFactory factory)
            {
                this.abstractProductA = factory.CreatePorductA();
                this.abstractProductB = factory.CreatePorductB();

            }


            public void Test()
            {
                Console.WriteLine(this.abstractProductA.MethodA());
                Console.WriteLine(this.abstractProductB.MethodB());
            }
        }

    }
}
