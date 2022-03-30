using System;

namespace ConsoleApp3
{
    public class Swan : Bird
    {
        public override int FeetCount { get; set; }

        public override void MakeSount()
        {
            Console.WriteLine("Qu Qu");
        }
        public override void Move()
        {
            Console.WriteLine("Fly with 2 wings");
        }
    }
}
