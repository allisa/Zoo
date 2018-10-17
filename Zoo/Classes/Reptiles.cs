using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Reptiles : Vertebrates
    {
        public override bool LaysEggs { get; set; } = true;
        public override bool IsWarmBlooded { get; set; } = false;
    }
}
