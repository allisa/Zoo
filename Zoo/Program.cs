using System;
using Zoo.Classes;
using Zoo.Interfaces;

namespace Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CallsForInvertebrates();
            CallsForVertebrates();
        }

        static void CallsForInvertebrates()
        {
            Spider trantulaSpider = new Spider();

            Console.WriteLine($"A spiders thought on stinging you: {trantulaSpider.MightAttack()}");
        }

        static void CallsForVertebrates()
        {
            Rattlesnake rattlesnake = new Rattlesnake();
            Robin robin = new Robin();
            Fish fishy = new Fish();
            Dog doggy = new Dog ();

            Console.WriteLine($"A rattlesnake makes the sound {rattlesnake.Sound()}");
            Console.WriteLine($"Can I swim? {robin.Swim()}");
            Console.WriteLine($"Can I fly? {fishy.Fly()}");
            Console.WriteLine($"Most of the time I have {doggy.HasLegs} legs, and makes the sound {doggy.Sound()}");
        }
    }
}
