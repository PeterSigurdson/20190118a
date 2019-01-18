using System;

namespace _20190118a
{
    class Program
    {
        static void Main(string[] args)
        {
            var Charlie = new Tuna();
        }
    }

    class Fish
    {
        public Fish() { Console.WriteLine("I am a Fish"); }
    }

    class Tuna : Fish
    {

    }
}
