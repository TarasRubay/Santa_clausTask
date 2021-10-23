using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaСlaus
{
    class FactoryBadPresents : AbstractFactory
    {
        public override AbstractEatPres EatPres()
        {
            return new BitterPills();
        }

        public override AbstractNotEatPres NotEatPres()
        {
            return new Twigs();
        }
    }
}
