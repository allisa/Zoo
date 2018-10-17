using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Rattlesnake : Reptiles, IAttack
    {
        public override int HasLegs { get; set; } = 0;

        public override bool Fly()
        {
            return false;
        }

        public override string Sound()
        {
            return "slither";
        }

        public string MightAttack()
        {
            return "If provoked or threatened, I attack";
        }


    }
}
