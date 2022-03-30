using System;

namespace ConsoleApp3
{
    public abstract class Animal
    {
        public abstract int FeetCount { get; set; }
        public int Weight { get; set; }
        public Animal()
        {
            Console.WriteLine("Animal created");
        }

        public string Test()
        {
            return "Test";
        }

        public abstract void MakeSount();

        public virtual void Move()
        {
            Console.WriteLine("Moved somehow");
        }
    }
}
