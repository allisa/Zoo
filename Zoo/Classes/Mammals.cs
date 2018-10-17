using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammals : Vertebrates
    {
        public override string Swim()
        {
            return "Some mammals swim";
        }

        public override bool IsWarmBlooded { get; set; } = true;

    }
}
