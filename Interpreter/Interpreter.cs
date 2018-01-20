using System;
namespace Design_Patterns_in_CSharp.Interpreter
{
    public class Context
    {

    }

    public interface IAbstractExpression
    {
        void Interpret(Context context);
    }

    public class TerminalExpression : IAbstractExpression
    {
        public void Interpret(Context context) => Console.WriteLine("`interpret` method of TerminalExpression is being called!");
    }

    public class NonterminalExpression : IAbstractExpression
    {
        public void Interpret(Context context) => Console.WriteLine("`interpret` method of NonterminalExpression is being called!");
    }

}
