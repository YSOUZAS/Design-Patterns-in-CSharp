using System;
namespace Design_Patterns_in_CSharp.Adapter
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {
            var adapter = new Adapter();
            adapter.Call();
        }
    }
}
