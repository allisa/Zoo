using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Arthropods : Invertebrates
    {
        public override string Sound()
        {
            return "Skitter";
        }
    }
}
