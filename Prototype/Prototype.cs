using System;
using System.Collections.Generic;
namespace Design_Patterns_in_CSharp.Prototype
{

    public interface IPrototype
    {
        IPrototype Clone();
        string ToString();
    }

    public class Concrete1 : IPrototype
    {
        public IPrototype Clone() => new Concrete1();

        public override string ToString() => "This is Concrete1";
    }

    public class Concrete2 : IPrototype
    {
        public IPrototype Clone() => new Concrete2();

        public override string ToString() => "This is Concrete2";
    }

    public class Concrete3 : IPrototype
    {
        public IPrototype Clone() => new Concrete3();

        public override string ToString() => "This is Concrete3";
    }

    public class Builder
    {
        private Dictionary<String, IPrototype> prototype = new Dictionary<string, IPrototype>();

        public Builder()
        {
            this.prototype.Add("c1", new Concrete1());
            this.prototype.Add("c2", new Concrete2());
            this.prototype.Add("c3", new Concrete3());

        }

        public IPrototype CreateOne(string s)
        {
            Console.WriteLine(s);
            return this.prototype[s].Clone();
        }
    }



}
