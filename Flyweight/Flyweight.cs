using System;
using System.Collections.Generic;
namespace Design_Patterns_in_CSharp.Flyweight
{
    public interface IFlyweight
    {
        void Operation(string s);
    }
    public class ConcreteFlyweight : IFlyweight
    {
        private string instrinsicState;

        public ConcreteFlyweight(string instrinsicState) => this.instrinsicState = instrinsicState;
        public void Operation(string s) => Console.WriteLine("`operation` of ConcreteFlyweight", s, " is being called!");
    }
    public class UnsharedConcreteFlyweight : IFlyweight
    {
        private int allState;

        public UnsharedConcreteFlyweight(int allState) => this.allState = allState;
        public void Operation(string s) => Console.WriteLine("`operation` of UnsharedConcreteFlyweight " + s + " is being called!");
    }

    public class FlyweightFactory
    {
        private Dictionary<string, IFlyweight> fliesMap = new Dictionary<string, IFlyweight>();

        public IFlyweight GetFlyweight(string key) {
            if (!this.fliesMap.ContainsKey(key))
                this.fliesMap.Add(key, new ConcreteFlyweight(key));
            return this.fliesMap[key];
        }
    }

}
