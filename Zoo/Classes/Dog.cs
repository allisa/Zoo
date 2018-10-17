using System;
using System.Collections.Generic;
using System.Text;


namespace Zoo.Classes
{
    public class Dog : Mammals
    {
        public override bool LaysEggs { get; set; } = false;

        public override int HasLegs { get; set; } = 4;

        public override bool Fly()
        {
            return false;
        }

        public override string Sound()
        {
            return "Woofy Woofy Bark Bark";
        }
    }
}
