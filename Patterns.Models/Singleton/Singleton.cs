using System;

namespace Patterns.Models.Singleton
{
    public class Singleton
    {
        private string Id = Guid.NewGuid().ToString();
        private static Singleton Instance;

        private Singleton() {}

        public static Singleton GetInstance()
        {
            if (Instance == null) 
            {
                Instance = new Singleton();
            }
            
            return Instance;
        }

        public override string ToString()
        {
            return Id;
        }
    }
}