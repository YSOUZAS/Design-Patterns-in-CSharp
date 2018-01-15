using System;
namespace Design_Patterns_in_CSharp.Interpreter
{
    public class Context
    {

    }

    public interface AbstractExpression
    {
        void Interpret(Context context);
    }

    public class TerminalExpression : AbstractExpression
    {
        public void Interpret(Context context) => Console.WriteLine("`interpret` method of TerminalExpression is being called!");
    }

    public class NonterminalExpression : AbstractExpression
    {
        public void Interpret(Context context) => Console.WriteLine("`interpret` method of NonterminalExpression is being called!");
    }

}
