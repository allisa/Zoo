using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Invertebrates : Animals
    {
        public virtual bool Venomous { get; set; } = false;
    }
}
