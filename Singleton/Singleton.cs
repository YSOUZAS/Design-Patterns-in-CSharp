using System;
namespace Design_Patterns_in_CSharp.Singleton
{
    public class Singleton
    {
        private static Singleton singleton = null;

        public static Singleton Instance() => singleton ?? (singleton = new Singleton());

    }
}

