using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
   public class Robin : Birds
    {
        public override int HasLegs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Sound()
        {
            throw new NotImplementedException();
        }

        public override string Swim()
        {
            return "Less of a swim and more of a dive";
        }
    }
}
