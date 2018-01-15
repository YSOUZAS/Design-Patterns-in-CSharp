using System;
namespace Design_Patterns_in_CSharp.FactoryMethod
{
    public interface IAbstractPorduct
    {
        string Method();
    }

    public class ConcreteProductA : IAbstractPorduct
    {
        public string Method() => "Method of ConcreteProductA";
    }

    public class ConcreteProductB : IAbstractPorduct
    {
        public string Method() => "Method of ConcreteProductB";
    }

    public class ProductFactory
    {
        public static IAbstractPorduct CreateProduct(string type)
        {
            if (type == "A")
                return new ConcreteProductA();
            else if (type == "B")
                return new ConcreteProductB();

            return null;
        }
    }

}
