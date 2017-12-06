using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Fish : Animal
    {
        public override string Name()
        {
            return "Fish";
        }
        public override string Voice()
        {
            return "Blup-blup!";
        }
    }
}
