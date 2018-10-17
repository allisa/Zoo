using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Vertebrates : Animals

    {
        public abstract bool IsWarmBlooded { get; set; }

        public virtual bool LaysEggs { get; set; } = false;

        public virtual string Swim()
        {
            return "Swims swimmingly";
        }

        public abstract bool Fly();

    }
}
