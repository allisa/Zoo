using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Fish : Vertebrates
    {
        public override bool IsWarmBlooded { get; set; } = true;
        public override int HasLegs { get; set; } = 0;

        public override bool Fly()
        {
            return false;
        }

        public override string Sound()
        {
            return "Swishing";
        }
    }
}
