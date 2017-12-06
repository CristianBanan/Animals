using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : Animal
    {
        public override string Name()
        {
            return "Frog";
        }
        public override string Voice()
        {
            return "Craok-croak!";
        }
    }
}
