using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Birds : Vertebrates
    {
        public override bool LaysEggs { get; set; } = true;

        public override bool IsWarmBlooded { get; set; } = true;

        public override bool Fly()
        {
            return true;
        }
    }
}
