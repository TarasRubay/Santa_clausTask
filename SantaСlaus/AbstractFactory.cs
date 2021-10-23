using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaСlaus
{
    abstract class AbstractFactory
    {
        public abstract AbstractEatPres EatPres();
        public abstract AbstractNotEatPres NotEatPres();
       
    }
}
