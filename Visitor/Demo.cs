﻿using System;
namespace Design_Patterns_in_CSharp.Visitor
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {
            var objs = new Objs();
            objs.Attach(new ConcreteElement1());
            objs.Attach(new ConcreteElement2());

            var v1 = new ConcreteVisitor1();
            var v2 = new ConcreteVisitor2();

            objs.Operate(v1);
            objs.Operate(v2);

        }
    }
}
