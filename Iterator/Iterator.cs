using System;
using System.Collections.Generic;
using System.Linq;
namespace Design_Patterns_in_CSharp.Iterator
{

    public interface IIterator
    {
        int Next();
        Boolean HasNext();
    }

    public interface IAggregator
    {
        IIterator CreateIterator();
    }

    public class ConcreteIterator : IIterator
    {
        private List<int> collection = new List<int>();
        private int position = 0;

        public ConcreteIterator(List<int> collection) => this.collection = collection;


        public bool HasNext() => position < collection.Count();

        public int Next()
        {
            var result = this.collection[this.position];
            this.position += 1;
            return result;
        }
    }


}
