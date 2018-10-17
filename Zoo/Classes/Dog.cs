using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;


namespace Zoo.Classes
{
    public class Dog : Mammals, IAmDomesticated
    {
        public override bool LaysEggs { get; set; } = false;

        public override int HasLegs { get; set; } = 4;

        public override bool Fly()
        {
            return false;
        }

        public string LiveInsideHomes()
        {
            return "People love me to cuddle with them";
        }

        public override string Sound()
        {
            return "Woofy Woofy Bark Bark";
        }


    }
}
