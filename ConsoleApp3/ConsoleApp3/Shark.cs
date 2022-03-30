using System;

namespace ConsoleApp3
{
    public class Shark : Fish
    {
        public override int FeetCount { get; set; }

        public int Speed { get; set; }
        public sealed override void MakeSount()
        {
            Console.WriteLine("Nom Nom!");
        }
    }
}
