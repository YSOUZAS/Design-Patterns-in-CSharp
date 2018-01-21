using System;
using System.Collections.Generic;
namespace Design_Patterns_in_CSharp.Interpreter
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {

            var context = new Context();
            var list = new LinkedList<IAbstractExpression>();

            list.AddLast(new NonterminalExpression());
            list.AddLast(new NonterminalExpression());
            list.AddLast(new NonterminalExpression());
            list.AddLast(new TerminalExpression());
            list.AddLast(new NonterminalExpression());
            list.AddLast(new NonterminalExpression());
            list.AddLast(new TerminalExpression());
            list.AddLast(new TerminalExpression());

            foreach (var item in list)
            {
                item.Interpret(context);
            }
        }
    }
}
