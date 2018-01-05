using System;
namespace Design_Patterns_in_CSharp.Singleton
{
    public class Singleton
    {
        private static Singleton singleton = null;
        public Singleton()
        {
        }

        public static Singleton Instance()
        {
            return singleton == null ? singleton = new Singleton() : singleton;
        }

    }
}

