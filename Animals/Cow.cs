using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cow : Animal
    {
        public override string Name()
        {
            return "Cow";
        }
        public override string Voice()
        {
            return "Moo-moo!";
        }
    }
}
