using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Animals
    {

        public abstract int HasLegs { get; set; }

        public abstract string Sound();

        public virtual string Eat()
        {
            return "Sounds";
        }
    }
}
