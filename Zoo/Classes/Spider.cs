using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Spider : Arthropods, IAttack, IAmDomesticated
    {
        public override bool Venomous { get; set; } = true;
        public override int HasLegs { get; set; } = 6;
        public override string Eat()
        {
            return "Insects";
        }

        public string MightAttack()
        {
            return "Depends on my type but I could kill you";
        }

        public string LiveInsideHomes()
        {
            return "I think it's odd to own a spider but some people do it";
        }
    }
}
