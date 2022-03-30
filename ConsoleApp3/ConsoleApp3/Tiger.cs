using System;

namespace ConsoleApp3
{
    public class Tiger : Animal
    {
        public override int FeetCount { get; set; }

        public override void MakeSount()
        {
            Console.WriteLine("Rawr");
        }

        public override void Move()
        {
            Console.WriteLine("Run with 4 feet");
        }
    }
}
