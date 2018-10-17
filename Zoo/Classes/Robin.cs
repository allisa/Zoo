using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
   public class Robin : Birds
    {
        public override int HasLegs { get; set; } = 2;

        public override string Sound()
        {
            return "chirp chirp";
        }

        public override string Swim()
        {
            return "Less of a swim and more of a dive";
        }
    }
}
