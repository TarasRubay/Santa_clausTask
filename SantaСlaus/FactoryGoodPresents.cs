using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaСlaus
{
    class FactoryGoodPresents : AbstractFactory
    {
        public override AbstractEatPres EatPres()
        {
            return new Sweets();
        }

        public override AbstractNotEatPres NotEatPres()
        {
            return new Toys();
        }
    }
}
